namespace JackFormsExample.singletons {
    public class Example_singleton_method {

        private Example_singleton_method() {

        }

        private static Example_singleton_method? _instance = null;
        public static Example_singleton_method GetInstance() {
            if (_instance == null) {
                _instance = new Example_singleton_method();
                Form1.log_singletons_static_classes.Text += "Running [Example_singleton_method] constructor!\r\n";
            }
            return _instance;
        }
        public void Print() {
            Form1.log_singletons_static_classes.Text += "I wear a Fez now, fezzes are cool\r\n";
        }
    }
}
