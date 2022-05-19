namespace JackFormsExample.singletons {
    public static class Example_static_class {
        static Example_static_class() {
            Form1.log_singletons_static_classes.Text += "Running [Example_static_class] constructor!\r\n";
        }
        public static void Print() {
            Form1.log_singletons_static_classes.Text += "Follow the white rabbit\r\n";
        }
    }
}
