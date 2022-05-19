namespace JackFormsExample.referencing {
    public class Example1 {
        private Form1 form1;
        public Example1(Form1 form1) {
            this.form1 = form1;
        }
        public void print() {
            Form1.log_references_between_instances.Text += "there is no spoon\r\n";
        }
    }
}