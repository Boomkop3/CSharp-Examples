namespace JackFormsExample.referencing {
    public class Example2 {
        private RichTextBox box;
        public Example2(RichTextBox box) {
            this.box = box;
        }
        public void print() {
            box.Text += "Don't eat pears!\r\n";
        }
    }
}