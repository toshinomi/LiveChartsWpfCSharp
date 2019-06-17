using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChartsWpfCSharp
{
    public class ComOpenFileDialog
    {
        protected OpenFileDialog m_openFileDialog;

        public String FileName
        {
            set { m_openFileDialog.FileName = value; }
            get { return m_openFileDialog.FileName; }
        }
        public String InitialDirectory
        {
            set { m_openFileDialog.InitialDirectory = value; }
            get { return m_openFileDialog.InitialDirectory; }
        }

        public String Filter
        {
            set { m_openFileDialog.Filter = value; }
            get { return m_openFileDialog.Filter; }
        }

        public int FilterIndex
        {
            set { m_openFileDialog.FilterIndex = value; }
            get { return m_openFileDialog.FilterIndex; }
        }

        public String Title
        {
            set { m_openFileDialog.Title = value; }
            get { return m_openFileDialog.Title; }
        }

        public bool CheckFileExists
        {
            set { m_openFileDialog.CheckFileExists = value; }
            get { return m_openFileDialog.CheckFileExists; }
        }

        public bool CheckPathExists
        {
            set { m_openFileDialog.CheckPathExists = value; }
            get { return m_openFileDialog.CheckPathExists; }
        }

        public ComOpenFileDialog()
        {
            m_openFileDialog = new OpenFileDialog();
        }

        ~ComOpenFileDialog()
        {
        }

        public bool ShowDialog()
        {
            bool bRst = false;

            if (m_openFileDialog.ShowDialog() == true)
            {
                bRst = true;
            }

            return bRst;
        }
    }
}