namespace JackFormsExample.singletons {
    public class Example_singleton_property {
        private static Example_singleton_property? _instance = null;
        public static Example_singleton_property instance {
            get {
                if (_instance == null) {
                    _instance = new Example_singleton_property();
                    Form1.log_singletons_static_classes.Text += "Running [Example_singleton_property] constructor!\r\n";
                }
                return _instance;
            }
        }
        public void Print() {
            Form1.log_singletons_static_classes.Text += "Fish fingers and custard\r\n";
        }
    }
}
