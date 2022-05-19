namespace JackFormsExample {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Tbx_references_between_instances = new System.Windows.Forms.RichTextBox();
            this.Print_directly_to_textbox = new System.Windows.Forms.Button();
            this.Print_via_form1_reference = new System.Windows.Forms.Button();
            this.Print_via_textbox_reference = new System.Windows.Forms.Button();
            this.Print_from_another_thread = new System.Windows.Forms.Button();
            this.Print_via_reference_multiple_layers_down = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Print_from_static_class = new System.Windows.Forms.Button();
            this.Print_from_java_like_singleton_method_property = new System.Windows.Forms.Button();
            this.Print_from_java_like_singleton_method = new System.Windows.Forms.Button();
            this.Tbx_singletons_static_classes = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbx_references_between_instances
            // 
            this.Tbx_references_between_instances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_references_between_instances.Location = new System.Drawing.Point(302, 6);
            this.Tbx_references_between_instances.Name = "Tbx_references_between_instances";
            this.Tbx_references_between_instances.Size = new System.Drawing.Size(516, 453);
            this.Tbx_references_between_instances.TabIndex = 0;
            this.Tbx_references_between_instances.Text = "";
            // 
            // Print_directly_to_textbox
            // 
            this.Print_directly_to_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_directly_to_textbox.Location = new System.Drawing.Point(4, 6);
            this.Print_directly_to_textbox.Name = "Print_directly_to_textbox";
            this.Print_directly_to_textbox.Size = new System.Drawing.Size(292, 23);
            this.Print_directly_to_textbox.TabIndex = 1;
            this.Print_directly_to_textbox.Text = "Print directly to textbox";
            this.Print_directly_to_textbox.UseVisualStyleBackColor = true;
            this.Print_directly_to_textbox.Click += new System.EventHandler(this.Print_directly_to_textbox_Click);
            // 
            // Print_via_form1_reference
            // 
            this.Print_via_form1_reference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_via_form1_reference.Location = new System.Drawing.Point(4, 35);
            this.Print_via_form1_reference.Name = "Print_via_form1_reference";
            this.Print_via_form1_reference.Size = new System.Drawing.Size(292, 23);
            this.Print_via_form1_reference.TabIndex = 1;
            this.Print_via_form1_reference.Text = "Print via form1 reference";
            this.Print_via_form1_reference.UseVisualStyleBackColor = true;
            this.Print_via_form1_reference.Click += new System.EventHandler(this.Print_via_form1_reference_Click);
            // 
            // Print_via_textbox_reference
            // 
            this.Print_via_textbox_reference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_via_textbox_reference.Location = new System.Drawing.Point(4, 64);
            this.Print_via_textbox_reference.Name = "Print_via_textbox_reference";
            this.Print_via_textbox_reference.Size = new System.Drawing.Size(292, 23);
            this.Print_via_textbox_reference.TabIndex = 1;
            this.Print_via_textbox_reference.Text = "Print via textbox reference";
            this.Print_via_textbox_reference.UseVisualStyleBackColor = true;
            this.Print_via_textbox_reference.Click += new System.EventHandler(this.Print_via_textbox_reference_Click);
            // 
            // Print_from_another_thread
            // 
            this.Print_from_another_thread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_from_another_thread.Location = new System.Drawing.Point(4, 93);
            this.Print_from_another_thread.Name = "Print_from_another_thread";
            this.Print_from_another_thread.Size = new System.Drawing.Size(292, 23);
            this.Print_from_another_thread.TabIndex = 1;
            this.Print_from_another_thread.Text = "Print from another thread";
            this.Print_from_another_thread.UseVisualStyleBackColor = true;
            this.Print_from_another_thread.Click += new System.EventHandler(this.Print_from_another_thread_Click);
            // 
            // Print_via_reference_multiple_layers_down
            // 
            this.Print_via_reference_multiple_layers_down.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_via_reference_multiple_layers_down.Location = new System.Drawing.Point(4, 122);
            this.Print_via_reference_multiple_layers_down.Name = "Print_via_reference_multiple_layers_down";
            this.Print_via_reference_multiple_layers_down.Size = new System.Drawing.Size(292, 23);
            this.Print_via_reference_multiple_layers_down.TabIndex = 1;
            this.Print_via_reference_multiple_layers_down.Text = "Print via reference multiple layers down";
            this.Print_via_reference_multiple_layers_down.UseVisualStyleBackColor = true;
            this.Print_via_reference_multiple_layers_down.Click += new System.EventHandler(this.Print_via_reference_multiple_layers_down_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 493);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Print_directly_to_textbox);
            this.tabPage1.Controls.Add(this.Tbx_references_between_instances);
            this.tabPage1.Controls.Add(this.Print_via_reference_multiple_layers_down);
            this.tabPage1.Controls.Add(this.Print_via_form1_reference);
            this.tabPage1.Controls.Add(this.Print_from_another_thread);
            this.tabPage1.Controls.Add(this.Print_via_textbox_reference);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "References between classes/instances";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Print_from_static_class);
            this.tabPage2.Controls.Add(this.Print_from_java_like_singleton_method_property);
            this.tabPage2.Controls.Add(this.Print_from_java_like_singleton_method);
            this.tabPage2.Controls.Add(this.Tbx_singletons_static_classes);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Singletons / Static classes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Print_from_static_class
            // 
            this.Print_from_static_class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_from_static_class.Location = new System.Drawing.Point(4, 64);
            this.Print_from_static_class.Name = "Print_from_static_class";
            this.Print_from_static_class.Size = new System.Drawing.Size(292, 23);
            this.Print_from_static_class.TabIndex = 3;
            this.Print_from_static_class.Text = "Print from static class";
            this.Print_from_static_class.UseVisualStyleBackColor = true;
            this.Print_from_static_class.Click += new System.EventHandler(this.Print_from_static_class_Click);
            // 
            // Print_from_java_like_singleton_method_property
            // 
            this.Print_from_java_like_singleton_method_property.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_from_java_like_singleton_method_property.Location = new System.Drawing.Point(4, 35);
            this.Print_from_java_like_singleton_method_property.Name = "Print_from_java_like_singleton_method_property";
            this.Print_from_java_like_singleton_method_property.Size = new System.Drawing.Size(292, 23);
            this.Print_from_java_like_singleton_method_property.TabIndex = 2;
            this.Print_from_java_like_singleton_method_property.Text = "Print from java-like singleton property";
            this.Print_from_java_like_singleton_method_property.UseVisualStyleBackColor = true;
            this.Print_from_java_like_singleton_method_property.Click += new System.EventHandler(this.Print_from_java_like_singleton_method_property_Click);
            // 
            // Print_from_java_like_singleton_method
            // 
            this.Print_from_java_like_singleton_method.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Print_from_java_like_singleton_method.Location = new System.Drawing.Point(4, 6);
            this.Print_from_java_like_singleton_method.Name = "Print_from_java_like_singleton_method";
            this.Print_from_java_like_singleton_method.Size = new System.Drawing.Size(292, 23);
            this.Print_from_java_like_singleton_method.TabIndex = 2;
            this.Print_from_java_like_singleton_method.Text = "Print from java-like singleton method";
            this.Print_from_java_like_singleton_method.UseVisualStyleBackColor = true;
            this.Print_from_java_like_singleton_method.Click += new System.EventHandler(this.Print_from_java_like_singleton_method_Click);
            // 
            // Tbx_singletons_static_classes
            // 
            this.Tbx_singletons_static_classes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_singletons_static_classes.Location = new System.Drawing.Point(302, 6);
            this.Tbx_singletons_static_classes.Name = "Tbx_singletons_static_classes";
            this.Tbx_singletons_static_classes.Size = new System.Drawing.Size(516, 453);
            this.Tbx_singletons_static_classes.TabIndex = 1;
            this.Tbx_singletons_static_classes.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "C# Examples";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox Tbx_references_between_instances;
        private Button Print_directly_to_textbox;
        private Button Print_via_form1_reference;
        private Button Print_via_textbox_reference;
        private Button Print_from_another_thread;
        private Button Print_via_reference_multiple_layers_down;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button Print_from_java_like_singleton_method;
        private RichTextBox Tbx_singletons_static_classes;
        private Button Print_from_static_class;
        private Button Print_from_java_like_singleton_method_property;
    }
}