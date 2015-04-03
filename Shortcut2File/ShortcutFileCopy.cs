using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tose2125.Shortcut2File
{
    class ShortcutFileCopy
    {
        public void Main(String folderPath, Boolean overWrite = false, Boolean fileMove = false, Boolean shortcutDelete = false)
        {
            if (Directory.Exists(folderPath))
            {
                String[] shortcuts = GetShortcuts(folderPath);
                ChangeProgress(0, shortcuts.Length, "対象全" + shortcuts.Length + "件");
                for (int i = 0; i < shortcuts.Length; i++)
                {
                    Boolean error = false;
                    if (File.Exists(shortcuts[i]))
                    {
                        String shortcutTargetPath = GetShortcutTarget(shortcuts[i]);
                        if (File.Exists(shortcutTargetPath))
                        {
                            string copyTargetPath = folderPath + "\\" + Path.GetFileName(shortcutTargetPath);
                            if (!overWrite && File.Exists(copyTargetPath))
                            {
                                ChangeProgress(i + 1, shortcuts.Length, copyTargetPath + " <= " + shortcutTargetPath + " 既に存在するためコピーされません。");
                            }
                            else
                            {
                                //ファイルコピー
                                try
                                {
                                    File.Copy(shortcutTargetPath, copyTargetPath, overWrite);
                                }
                                catch (System.UnauthorizedAccessException e)
                                {
                                    ChangeProgress(i + 1, shortcuts.Length, copyTargetPath + " <= " + shortcutTargetPath + " コピーできません。 " + e.Message);
                                    error = true;
                                }
                                catch (IOException e)
                                {
                                    ChangeProgress(i + 1, shortcuts.Length, copyTargetPath + " <= " + shortcutTargetPath + " コピーできません。 " + e.Message);
                                    error = true;
                                }
                                //コピー元ファイル削除
                                try
                                {
                                    if (!error)
                                    {
                                        if (fileMove)
                                        {
                                            File.Delete(shortcutTargetPath);
                                            ChangeProgress(i + 1, shortcuts.Length, copyTargetPath + " <= " + shortcutTargetPath + "(削除) 移動しました。");
                                        }
                                        else
                                        {
                                            ChangeProgress(i + 1, shortcuts.Length, copyTargetPath + " <= " + shortcutTargetPath + " コピーしました。");
                                        }
                                    }
                                }
                                catch (System.UnauthorizedAccessException e)
                                {
                                    ChangeProgress(i + 1, shortcuts.Length, shortcutTargetPath + " コピー元 削除できません。 " + e.Message);
                                }
                                catch (IOException e)
                                {
                                    ChangeProgress(i + 1, shortcuts.Length, shortcutTargetPath + " コピー元 削除できません。 " + e.Message);
                                }
                                //ショートカット削除
                                try
                                {
                                    if (!error && shortcutDelete)
                                    {
                                        File.Delete(shortcuts[i]);
                                        ChangeProgress(i + 1, shortcuts.Length, shortcuts[i] + "(削除) ショートカット 削除しました。");
                                    }
                                }
                                catch (System.UnauthorizedAccessException e)
                                {
                                    ChangeProgress(i + 1, shortcuts.Length, shortcuts[i] + " ショートカット 削除できません。 " + e.Message);
                                }
                                catch (IOException e)
                                {
                                    ChangeProgress(i + 1, shortcuts.Length, shortcuts[i] + " ショートカット 削除できません。 " + e.Message);
                                }
                            }
                        }
                        else
                        {
                            ChangeProgress(i + 1, shortcuts.Length, shortcutTargetPath + " <= " + shortcuts[i] + " リンク先 存在しません。 (リンク切れ)");
                        }
                    }
                    else
                    {
                        ChangeProgress(i + 1, shortcuts.Length, shortcuts[i] + " ショートカット 存在しません。");
                    }
                }
            }
            else
            {
                ChangeProgress(0, 0, folderPath + " フォルダ 存在しません。");
            }
        }

        static String[] GetShortcuts(String folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                try
                {
                    return Directory.GetFiles(folderPath, "*.lnk");
                }
                catch (System.UnauthorizedAccessException e)
                {
                    return new string[1] { folderPath + " フォルダ 開けません。" + e.Message };
                }
                catch (IOException e)
                {
                    return new string[1] { folderPath + " フォルダ 開けません。" + e.Message };
                }
            }
            return new string[1] { folderPath + " フォルダ 存在しません。" };
        }
        static String GetShortcutTarget(String shortcutPath)
        {
            if (File.Exists(shortcutPath))
            {
                shortcutPath = Path.GetFullPath(shortcutPath);
                Shell32.Shell myShell = new Shell32.Shell();
                return ((Shell32.ShellLinkObject)myShell
                    .NameSpace(Path.GetDirectoryName(Path.GetFullPath(shortcutPath)))
                    .Items()
                    .Item(Path.GetFileName(Path.GetFullPath(shortcutPath)))
                    .GetLink)
                    .Target
                    .Path;
            }
            return "";
        }

        public event ChangeProgressEventHandler ProgressChanging;
        void ChangeProgress(Int32 count, Int32 all, String message)
        {
            if (ProgressChanging != null)
            {
                ProgressChanging(this, new ChangeProgressEventArgs(count, all, message));
            }
        }

    }
}
