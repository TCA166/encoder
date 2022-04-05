namespace Word_Encoder_2._0
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Security_Code_Title = new System.Windows.Forms.Label();
            this.code_raw_1 = new System.Windows.Forms.NumericUpDown();
            this.code_raw_2 = new System.Windows.Forms.NumericUpDown();
            this.code_raw_3 = new System.Windows.Forms.NumericUpDown();
            this.code_raw_4 = new System.Windows.Forms.NumericUpDown();
            this.code_raw_5 = new System.Windows.Forms.NumericUpDown();
            this.code_raw_6 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UnicodeTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.code_raw_unicode = new System.Windows.Forms.NumericUpDown();
            this.UnicodeDecode = new System.Windows.Forms.Button();
            this.UnicodeCopy = new System.Windows.Forms.Button();
            this.Unicode_Encode = new System.Windows.Forms.Button();
            this.UnicodeOutput = new System.Windows.Forms.TextBox();
            this.UnicodeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Base64Tab = new System.Windows.Forms.TabPage();
            this.Base64Decode = new System.Windows.Forms.Button();
            this.Base64Copy = new System.Windows.Forms.Button();
            this.Base64Encode = new System.Windows.Forms.Button();
            this.Base64Output = new System.Windows.Forms.TextBox();
            this.Base64Input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FileTab = new System.Windows.Forms.TabPage();
            this.AdvancedMode = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DecodeFile = new System.Windows.Forms.Button();
            this.SelectFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FileOutput = new System.Windows.Forms.TextBox();
            this.OneTimePadTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OneTimeDecrypt = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.OneTimeDecryptCode = new System.Windows.Forms.TextBox();
            this.OneTimeDecryptInput = new System.Windows.Forms.TextBox();
            this.OneTimeDecryptOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OneTimeEncrypt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OneTimeEncryptCode = new System.Windows.Forms.TextBox();
            this.OneTimeEncryptOutput = new System.Windows.Forms.TextBox();
            this.OneTimeEncryptInput = new System.Windows.Forms.TextBox();
            this.Randomize_code = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_6)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.UnicodeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_unicode)).BeginInit();
            this.Base64Tab.SuspendLayout();
            this.FileTab.SuspendLayout();
            this.OneTimePadTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(549, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(343, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "Word Encoder 2.0";
            // 
            // Security_Code_Title
            // 
            this.Security_Code_Title.AutoSize = true;
            this.Security_Code_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Security_Code_Title.Location = new System.Drawing.Point(-1, 26);
            this.Security_Code_Title.Name = "Security_Code_Title";
            this.Security_Code_Title.Size = new System.Drawing.Size(142, 25);
            this.Security_Code_Title.TabIndex = 1;
            this.Security_Code_Title.Text = "Security Code:";
            // 
            // code_raw_1
            // 
            this.code_raw_1.Location = new System.Drawing.Point(147, 30);
            this.code_raw_1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.code_raw_1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.code_raw_1.Name = "code_raw_1";
            this.code_raw_1.Size = new System.Drawing.Size(45, 20);
            this.code_raw_1.TabIndex = 2;
            this.code_raw_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // code_raw_2
            // 
            this.code_raw_2.Location = new System.Drawing.Point(198, 30);
            this.code_raw_2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.code_raw_2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.code_raw_2.Name = "code_raw_2";
            this.code_raw_2.Size = new System.Drawing.Size(45, 20);
            this.code_raw_2.TabIndex = 3;
            this.code_raw_2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // code_raw_3
            // 
            this.code_raw_3.Location = new System.Drawing.Point(249, 30);
            this.code_raw_3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.code_raw_3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.code_raw_3.Name = "code_raw_3";
            this.code_raw_3.Size = new System.Drawing.Size(45, 20);
            this.code_raw_3.TabIndex = 4;
            this.code_raw_3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // code_raw_4
            // 
            this.code_raw_4.Location = new System.Drawing.Point(300, 30);
            this.code_raw_4.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.code_raw_4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.code_raw_4.Name = "code_raw_4";
            this.code_raw_4.Size = new System.Drawing.Size(45, 20);
            this.code_raw_4.TabIndex = 5;
            this.code_raw_4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // code_raw_5
            // 
            this.code_raw_5.Location = new System.Drawing.Point(351, 30);
            this.code_raw_5.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.code_raw_5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.code_raw_5.Name = "code_raw_5";
            this.code_raw_5.Size = new System.Drawing.Size(45, 20);
            this.code_raw_5.TabIndex = 6;
            this.code_raw_5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // code_raw_6
            // 
            this.code_raw_6.Location = new System.Drawing.Point(402, 30);
            this.code_raw_6.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.code_raw_6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.code_raw_6.Name = "code_raw_6";
            this.code_raw_6.Size = new System.Drawing.Size(45, 20);
            this.code_raw_6.TabIndex = 7;
            this.code_raw_6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UnicodeTab);
            this.tabControl1.Controls.Add(this.Base64Tab);
            this.tabControl1.Controls.Add(this.FileTab);
            this.tabControl1.Controls.Add(this.OneTimePadTab);
            this.tabControl1.Location = new System.Drawing.Point(13, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1246, 500);
            this.tabControl1.TabIndex = 8;
            // 
            // UnicodeTab
            // 
            this.UnicodeTab.Controls.Add(this.label7);
            this.UnicodeTab.Controls.Add(this.code_raw_unicode);
            this.UnicodeTab.Controls.Add(this.UnicodeDecode);
            this.UnicodeTab.Controls.Add(this.UnicodeCopy);
            this.UnicodeTab.Controls.Add(this.Unicode_Encode);
            this.UnicodeTab.Controls.Add(this.UnicodeOutput);
            this.UnicodeTab.Controls.Add(this.UnicodeInput);
            this.UnicodeTab.Controls.Add(this.label2);
            this.UnicodeTab.Controls.Add(this.label1);
            this.UnicodeTab.Location = new System.Drawing.Point(4, 22);
            this.UnicodeTab.Name = "UnicodeTab";
            this.UnicodeTab.Padding = new System.Windows.Forms.Padding(3);
            this.UnicodeTab.Size = new System.Drawing.Size(1238, 474);
            this.UnicodeTab.TabIndex = 0;
            this.UnicodeTab.Text = "Unicode Encoding";
            this.UnicodeTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(575, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Variator";
            // 
            // code_raw_unicode
            // 
            this.code_raw_unicode.Location = new System.Drawing.Point(557, 74);
            this.code_raw_unicode.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.code_raw_unicode.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.code_raw_unicode.Name = "code_raw_unicode";
            this.code_raw_unicode.Size = new System.Drawing.Size(103, 20);
            this.code_raw_unicode.TabIndex = 8;
            // 
            // UnicodeDecode
            // 
            this.UnicodeDecode.Location = new System.Drawing.Point(804, 421);
            this.UnicodeDecode.Name = "UnicodeDecode";
            this.UnicodeDecode.Size = new System.Drawing.Size(114, 23);
            this.UnicodeDecode.TabIndex = 7;
            this.UnicodeDecode.Text = "Decode";
            this.UnicodeDecode.UseVisualStyleBackColor = true;
            this.UnicodeDecode.Click += new System.EventHandler(this.UnicodeDecode_Click);
            // 
            // UnicodeCopy
            // 
            this.UnicodeCopy.Location = new System.Drawing.Point(1077, 421);
            this.UnicodeCopy.Name = "UnicodeCopy";
            this.UnicodeCopy.Size = new System.Drawing.Size(155, 23);
            this.UnicodeCopy.TabIndex = 6;
            this.UnicodeCopy.Text = "Copy output to clipboard";
            this.UnicodeCopy.UseVisualStyleBackColor = true;
            this.UnicodeCopy.Click += new System.EventHandler(this.UnicodeCopy_Click);
            // 
            // Unicode_Encode
            // 
            this.Unicode_Encode.Location = new System.Drawing.Point(320, 421);
            this.Unicode_Encode.Name = "Unicode_Encode";
            this.Unicode_Encode.Size = new System.Drawing.Size(114, 23);
            this.Unicode_Encode.TabIndex = 5;
            this.Unicode_Encode.Text = "Encode";
            this.Unicode_Encode.UseVisualStyleBackColor = true;
            this.Unicode_Encode.Click += new System.EventHandler(this.Unicode_Encode_Click);
            // 
            // UnicodeOutput
            // 
            this.UnicodeOutput.Location = new System.Drawing.Point(804, 74);
            this.UnicodeOutput.Multiline = true;
            this.UnicodeOutput.Name = "UnicodeOutput";
            this.UnicodeOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UnicodeOutput.Size = new System.Drawing.Size(428, 341);
            this.UnicodeOutput.TabIndex = 4;
            // 
            // UnicodeInput
            // 
            this.UnicodeInput.Location = new System.Drawing.Point(6, 74);
            this.UnicodeInput.Multiline = true;
            this.UnicodeInput.Name = "UnicodeInput";
            this.UnicodeInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UnicodeInput.Size = new System.Drawing.Size(428, 341);
            this.UnicodeInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(999, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(175, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // Base64Tab
            // 
            this.Base64Tab.Controls.Add(this.Base64Decode);
            this.Base64Tab.Controls.Add(this.Base64Copy);
            this.Base64Tab.Controls.Add(this.Base64Encode);
            this.Base64Tab.Controls.Add(this.Base64Output);
            this.Base64Tab.Controls.Add(this.Base64Input);
            this.Base64Tab.Controls.Add(this.label3);
            this.Base64Tab.Controls.Add(this.label4);
            this.Base64Tab.Location = new System.Drawing.Point(4, 22);
            this.Base64Tab.Name = "Base64Tab";
            this.Base64Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Base64Tab.Size = new System.Drawing.Size(1238, 474);
            this.Base64Tab.TabIndex = 1;
            this.Base64Tab.Text = "Base64 Encoding";
            this.Base64Tab.UseVisualStyleBackColor = true;
            // 
            // Base64Decode
            // 
            this.Base64Decode.Location = new System.Drawing.Point(804, 421);
            this.Base64Decode.Name = "Base64Decode";
            this.Base64Decode.Size = new System.Drawing.Size(114, 23);
            this.Base64Decode.TabIndex = 14;
            this.Base64Decode.Text = "Decode";
            this.Base64Decode.UseVisualStyleBackColor = true;
            this.Base64Decode.Click += new System.EventHandler(this.Base64Decode_Click);
            // 
            // Base64Copy
            // 
            this.Base64Copy.Location = new System.Drawing.Point(1077, 421);
            this.Base64Copy.Name = "Base64Copy";
            this.Base64Copy.Size = new System.Drawing.Size(155, 23);
            this.Base64Copy.TabIndex = 13;
            this.Base64Copy.Text = "Copy output to clipboard";
            this.Base64Copy.UseVisualStyleBackColor = true;
            this.Base64Copy.Click += new System.EventHandler(this.Base64Copy_Click);
            // 
            // Base64Encode
            // 
            this.Base64Encode.Location = new System.Drawing.Point(320, 421);
            this.Base64Encode.Name = "Base64Encode";
            this.Base64Encode.Size = new System.Drawing.Size(114, 23);
            this.Base64Encode.TabIndex = 12;
            this.Base64Encode.Text = "Encode";
            this.Base64Encode.UseVisualStyleBackColor = true;
            this.Base64Encode.Click += new System.EventHandler(this.Base64Encode_Click);
            // 
            // Base64Output
            // 
            this.Base64Output.Location = new System.Drawing.Point(804, 74);
            this.Base64Output.Multiline = true;
            this.Base64Output.Name = "Base64Output";
            this.Base64Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Base64Output.Size = new System.Drawing.Size(428, 341);
            this.Base64Output.TabIndex = 11;
            // 
            // Base64Input
            // 
            this.Base64Input.Location = new System.Drawing.Point(6, 74);
            this.Base64Input.Multiline = true;
            this.Base64Input.Name = "Base64Input";
            this.Base64Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Base64Input.Size = new System.Drawing.Size(428, 341);
            this.Base64Input.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(999, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(175, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Input";
            // 
            // FileTab
            // 
            this.FileTab.Controls.Add(this.AdvancedMode);
            this.FileTab.Controls.Add(this.button2);
            this.FileTab.Controls.Add(this.DecodeFile);
            this.FileTab.Controls.Add(this.SelectFile);
            this.FileTab.Controls.Add(this.label6);
            this.FileTab.Controls.Add(this.label5);
            this.FileTab.Controls.Add(this.FileOutput);
            this.FileTab.Location = new System.Drawing.Point(4, 22);
            this.FileTab.Name = "FileTab";
            this.FileTab.Size = new System.Drawing.Size(1238, 474);
            this.FileTab.TabIndex = 2;
            this.FileTab.Text = "File Encoding";
            this.FileTab.UseVisualStyleBackColor = true;
            // 
            // AdvancedMode
            // 
            this.AdvancedMode.AutoSize = true;
            this.AdvancedMode.Location = new System.Drawing.Point(3, 454);
            this.AdvancedMode.Name = "AdvancedMode";
            this.AdvancedMode.Size = new System.Drawing.Size(318, 17);
            this.AdvancedMode.TabIndex = 18;
            this.AdvancedMode.Text = "Enable \"All files\" selection (migh not work with some file types)";
            this.AdvancedMode.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(804, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Copy to clipboard";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DecodeFile
            // 
            this.DecodeFile.Location = new System.Drawing.Point(1129, 421);
            this.DecodeFile.Name = "DecodeFile";
            this.DecodeFile.Size = new System.Drawing.Size(103, 23);
            this.DecodeFile.TabIndex = 16;
            this.DecodeFile.Text = "Decode and save File";
            this.DecodeFile.UseVisualStyleBackColor = true;
            this.DecodeFile.Click += new System.EventHandler(this.DecodeFile_Click);
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(148, 74);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(139, 34);
            this.SelectFile.TabIndex = 15;
            this.SelectFile.Text = "Select file to encode";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(999, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(175, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Input";
            // 
            // FileOutput
            // 
            this.FileOutput.Location = new System.Drawing.Point(804, 74);
            this.FileOutput.Multiline = true;
            this.FileOutput.Name = "FileOutput";
            this.FileOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileOutput.Size = new System.Drawing.Size(428, 341);
            this.FileOutput.TabIndex = 12;
            // 
            // OneTimePadTab
            // 
            this.OneTimePadTab.Controls.Add(this.groupBox2);
            this.OneTimePadTab.Controls.Add(this.groupBox1);
            this.OneTimePadTab.Location = new System.Drawing.Point(4, 22);
            this.OneTimePadTab.Name = "OneTimePadTab";
            this.OneTimePadTab.Size = new System.Drawing.Size(1238, 474);
            this.OneTimePadTab.TabIndex = 3;
            this.OneTimePadTab.Text = "One-time pad encryption";
            this.OneTimePadTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OneTimeDecrypt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.OneTimeDecryptCode);
            this.groupBox2.Controls.Add(this.OneTimeDecryptInput);
            this.groupBox2.Controls.Add(this.OneTimeDecryptOutput);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(6, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1232, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypt";
            // 
            // OneTimeDecrypt
            // 
            this.OneTimeDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OneTimeDecrypt.Location = new System.Drawing.Point(258, 186);
            this.OneTimeDecrypt.Name = "OneTimeDecrypt";
            this.OneTimeDecrypt.Size = new System.Drawing.Size(120, 23);
            this.OneTimeDecrypt.TabIndex = 7;
            this.OneTimeDecrypt.Text = "Decrypt";
            this.OneTimeDecrypt.UseVisualStyleBackColor = true;
            this.OneTimeDecrypt.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "One time pad (keep secret)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Encrypted text";
            // 
            // OneTimeDecryptCode
            // 
            this.OneTimeDecryptCode.Location = new System.Drawing.Point(6, 132);
            this.OneTimeDecryptCode.Multiline = true;
            this.OneTimeDecryptCode.Name = "OneTimeDecryptCode";
            this.OneTimeDecryptCode.Size = new System.Drawing.Size(372, 51);
            this.OneTimeDecryptCode.TabIndex = 8;
            // 
            // OneTimeDecryptInput
            // 
            this.OneTimeDecryptInput.Location = new System.Drawing.Point(6, 47);
            this.OneTimeDecryptInput.Multiline = true;
            this.OneTimeDecryptInput.Name = "OneTimeDecryptInput";
            this.OneTimeDecryptInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OneTimeDecryptInput.Size = new System.Drawing.Size(372, 62);
            this.OneTimeDecryptInput.TabIndex = 7;
            // 
            // OneTimeDecryptOutput
            // 
            this.OneTimeDecryptOutput.Location = new System.Drawing.Point(703, 55);
            this.OneTimeDecryptOutput.Multiline = true;
            this.OneTimeDecryptOutput.Name = "OneTimeDecryptOutput";
            this.OneTimeDecryptOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OneTimeDecryptOutput.Size = new System.Drawing.Size(520, 136);
            this.OneTimeDecryptOutput.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OneTimeEncrypt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.OneTimeEncryptCode);
            this.groupBox1.Controls.Add(this.OneTimeEncryptOutput);
            this.groupBox1.Controls.Add(this.OneTimeEncryptInput);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt";
            // 
            // OneTimeEncrypt
            // 
            this.OneTimeEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OneTimeEncrypt.Location = new System.Drawing.Point(261, 186);
            this.OneTimeEncrypt.Name = "OneTimeEncrypt";
            this.OneTimeEncrypt.Size = new System.Drawing.Size(120, 23);
            this.OneTimeEncrypt.TabIndex = 6;
            this.OneTimeEncrypt.Text = "Encrypt";
            this.OneTimeEncrypt.UseVisualStyleBackColor = true;
            this.OneTimeEncrypt.Click += new System.EventHandler(this.OneTimeEncrypt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(703, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "One time pad (keep secret)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(703, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Encrypted text";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Text to encrypt";
            // 
            // OneTimeEncryptCode
            // 
            this.OneTimeEncryptCode.Location = new System.Drawing.Point(706, 132);
            this.OneTimeEncryptCode.Multiline = true;
            this.OneTimeEncryptCode.Name = "OneTimeEncryptCode";
            this.OneTimeEncryptCode.Size = new System.Drawing.Size(520, 51);
            this.OneTimeEncryptCode.TabIndex = 2;
            // 
            // OneTimeEncryptOutput
            // 
            this.OneTimeEncryptOutput.Location = new System.Drawing.Point(706, 47);
            this.OneTimeEncryptOutput.Multiline = true;
            this.OneTimeEncryptOutput.Name = "OneTimeEncryptOutput";
            this.OneTimeEncryptOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OneTimeEncryptOutput.Size = new System.Drawing.Size(520, 62);
            this.OneTimeEncryptOutput.TabIndex = 1;
            // 
            // OneTimeEncryptInput
            // 
            this.OneTimeEncryptInput.Location = new System.Drawing.Point(6, 47);
            this.OneTimeEncryptInput.Multiline = true;
            this.OneTimeEncryptInput.Name = "OneTimeEncryptInput";
            this.OneTimeEncryptInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OneTimeEncryptInput.Size = new System.Drawing.Size(375, 136);
            this.OneTimeEncryptInput.TabIndex = 0;
            // 
            // Randomize_code
            // 
            this.Randomize_code.Location = new System.Drawing.Point(453, 30);
            this.Randomize_code.Name = "Randomize_code";
            this.Randomize_code.Size = new System.Drawing.Size(90, 23);
            this.Randomize_code.TabIndex = 9;
            this.Randomize_code.Text = "Randomize";
            this.Randomize_code.UseVisualStyleBackColor = true;
            this.Randomize_code.Click += new System.EventHandler(this.Randomize_code_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1184, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Randomize_code);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.code_raw_6);
            this.Controls.Add(this.code_raw_5);
            this.Controls.Add(this.code_raw_4);
            this.Controls.Add(this.code_raw_3);
            this.Controls.Add(this.code_raw_2);
            this.Controls.Add(this.code_raw_1);
            this.Controls.Add(this.Security_Code_Title);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Word Encoder 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_6)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.UnicodeTab.ResumeLayout(false);
            this.UnicodeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.code_raw_unicode)).EndInit();
            this.Base64Tab.ResumeLayout(false);
            this.Base64Tab.PerformLayout();
            this.FileTab.ResumeLayout(false);
            this.FileTab.PerformLayout();
            this.OneTimePadTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Security_Code_Title;
        private System.Windows.Forms.NumericUpDown code_raw_1;
        private System.Windows.Forms.NumericUpDown code_raw_2;
        private System.Windows.Forms.NumericUpDown code_raw_3;
        private System.Windows.Forms.NumericUpDown code_raw_4;
        private System.Windows.Forms.NumericUpDown code_raw_5;
        private System.Windows.Forms.NumericUpDown code_raw_6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UnicodeTab;
        private System.Windows.Forms.TabPage Base64Tab;
        private System.Windows.Forms.TabPage FileTab;
        private System.Windows.Forms.TextBox UnicodeOutput;
        private System.Windows.Forms.TextBox UnicodeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Unicode_Encode;
        private System.Windows.Forms.Button UnicodeCopy;
        private System.Windows.Forms.Button UnicodeDecode;
        private System.Windows.Forms.Button Randomize_code;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Base64Decode;
        private System.Windows.Forms.Button Base64Copy;
        private System.Windows.Forms.Button Base64Encode;
        private System.Windows.Forms.TextBox Base64Output;
        private System.Windows.Forms.TextBox Base64Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FileOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.Button DecodeFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox AdvancedMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown code_raw_unicode;
        private System.Windows.Forms.TabPage OneTimePadTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox OneTimeEncryptInput;
        private System.Windows.Forms.TextBox OneTimeEncryptOutput;
        private System.Windows.Forms.TextBox OneTimeEncryptCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button OneTimeEncrypt;
        private System.Windows.Forms.Button OneTimeDecrypt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox OneTimeDecryptCode;
        private System.Windows.Forms.TextBox OneTimeDecryptInput;
        private System.Windows.Forms.TextBox OneTimeDecryptOutput;
    }
}

