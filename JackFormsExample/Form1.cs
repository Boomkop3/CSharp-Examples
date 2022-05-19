
using JackFormsExample.referencing;
using JackFormsExample.singletons;

namespace JackFormsExample {
    public partial class Form1 : Form {
        private static Form1? instance;
        public Form1() {
            instance = this;
            InitializeComponent();
        }

        public static RichTextBox log_references_between_instances {
            get => instance!.Tbx_references_between_instances;
        }

        public static RichTextBox log_singletons_static_classes {
            get => instance!.Tbx_singletons_static_classes;
        }

        private void Print_directly_to_textbox_Click(object sender, EventArgs e) {
            Tbx_references_between_instances.Text += "hello world\r\n";
        }

        private void Print_via_form1_reference_Click(object sender, EventArgs e) {
            var printer = new Example1(this);
            printer.print();
        }

        private void Print_via_reference_multiple_layers_down_Click(object sender, EventArgs e) {
            var printer = new Example3(this);
            printer.print();
        }

        private void Print_via_textbox_reference_Click(object sender, EventArgs e) {
            var printer = new Example2(Tbx_references_between_instances);
            printer.print();
        }

        private void Print_from_another_thread_Click(object sender, EventArgs e) {
            void print_spam(string word) {
                for (int i = 0; i < 10; i++) {
                    Thread.Sleep(5);
                    Tbx_references_between_instances.Invoke(() => {
                        Tbx_references_between_instances.Text += word;
                    });
                }
            }
            Task.Run(() => {
                var task1 = new Task(() => {
                    print_spam("A");
                });
                var task2 = new Task(() => {
                    print_spam("B");
                });
                task1.Start();
                task2.Start();
                task1.Wait();
                task2.Wait();
                Tbx_references_between_instances.Invoke(() => {
                    Tbx_references_between_instances.Text += "\r\n";
                });
            });
        }
        private void Print_from_java_like_singleton_method_Click(object sender, EventArgs e) {
            Example_singleton_method.GetInstance().Print();
        }

        private void Print_from_java_like_singleton_method_property_Click(object sender, EventArgs e) {
            Example_singleton_property.instance.Print();
        }

        private void Print_from_static_class_Click(object sender, EventArgs e) {
            Example_static_class.Print();
        }
    }
}
