namespace JackFormsExample.referencing {
    public class Example3 {
        private Example3_1 other;
        public Example3(Form1 form1) {
            other = new Example3_1(form1);
        }
        public void print() {
            other.print();
        }
    }
}