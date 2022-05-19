namespace JackFormsExample.referencing {
    public class Example3_1 {
        private Form1 form1;
        public Example3_1(Form1 form1) {
            this.form1 = form1;
        }
        public void print() {
            Form1.log_references_between_instances.Text += "union rings\r\n";
        }
    }
}