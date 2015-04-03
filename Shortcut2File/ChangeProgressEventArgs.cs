using System;

namespace Tose2125.Shortcut2File
{
    public class ChangeProgressEventArgs : EventArgs
    {
        public ChangeProgressEventArgs(Int32 count, Int32 all, String message)
        {
            _count = count;
            _all = all;
            _message = message;
        }

        private Int32 _count;
        public Int32 Count
        {
            get { return _count; }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException(); }
                _count = value;
            }
        }
        private Int32 _all;
        public Int32 All
        {
            get { return _all; }
            set
            {
                if (value < 0) { throw new ArgumentOutOfRangeException(); }
                _all = value;
            }
        }
        private String _message;
        public String Message
        {
            get { return _message; }
            set
            {
                if (value == null) { throw new ArgumentNullException(); }
                _message = value;
            }
        }
    }
    public delegate String[] ChangeProgressEventHandler(object sender, ChangeProgressEventArgs e);
}
