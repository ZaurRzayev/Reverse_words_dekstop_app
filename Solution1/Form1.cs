using System.Text;

namespace Solution1
{
    public partial class Form1 : Form
    {

        string TextFile = @"C:\Test\test.txt";
        string OutputFile = @"C:\Test\Output.txt";
        public Form1()
        {
            InitializeComponent();
        }
       /* public string ReverseWords(string originalString)
        {
            StringBuilder reverseWordString = new StringBuilder();
            List<char> charlist = new List<char>();

            for (int i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == ' ' || i == originalString.Length - 1)
                {
                    if (i == originalString.Length - 1)
                        charlist.Add(originalString[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        reverseWordString.Append(charlist[j]);

                    reverseWordString.Append(' ');
                    charlist = new List<char>();
                }
                else
                {
                    charlist.Add(originalString[i]);
                }
            }

            return reverseWordString.ToString();
        }*/

        public string ReverseWords(string originalString)
        {
            
            char[] stringArray = originalString.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            return reversedStr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (File.Exists(TextFile))
            {
                string[] originalString = File.ReadAllLines(TextFile);
                string[] strings = new string[originalString.Length];
                for (int i = 0;i < originalString.Length;i++)
                {
                    strings[i] = ReverseWords(originalString[i]);
                }
                string result= string.Join("\r\n", strings);
                label2.Text = result;
                try
                {
                    // Create a StreamWriter to write to the file
                    using (StreamWriter writer = new StreamWriter(OutputFile))
                    {
                        // Write the text to the file
                        writer.WriteLine(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

        }

        private void Words_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Create a StreamWriter to open the file in write mode
                using (StreamWriter writer = new StreamWriter(OutputFile, false))
                {
                    // The second argument (false) in the StreamWriter constructor
                    // specifies that the file should be overwritten, clearing its content.
                }

                Console.WriteLine("File content has been cleared.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}