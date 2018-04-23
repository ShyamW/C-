using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFBattle
{
    class StreamWriter : System.IO.TextWriter
    {

        public override void Write(char value)
        {
            base.Write(value);
            output.Dispatcher.BeginInvoke(new Action(() =>
            {
                output.Focus();
                output.AppendText(value.ToString());
                output.CaretIndex = output.Text.Length;
                output.ScrollToEnd();
            })
            ); 
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }

        private TextBox output;

        public StreamWriter(TextBox x)
        {
            this.output = x;
        }

        

    }
}
