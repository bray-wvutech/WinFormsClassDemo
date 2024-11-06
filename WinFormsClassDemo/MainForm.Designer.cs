namespace WinFormsClassDemo;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        modalButton = new Button();
        modelessButton = new Button();
        nameTextBox = new TextBox();
        ageTextBox = new TextBox();
        nameLabel = new Label();
        ageLabel = new Label();
        staticTestLabel = new Label();
        oddCheckBox = new CheckBox();
        evenCheckBox = new CheckBox();
        colorButton = new Button();
        listBox1 = new ListBox();
        animalButton = new Button();
        interfaceButton = new Button();
        interface2Button = new Button();
        SuspendLayout();
        // 
        // modalButton
        // 
        modalButton.Location = new Point(73, 219);
        modalButton.Name = "modalButton";
        modalButton.Size = new Size(250, 29);
        modalButton.TabIndex = 1;
        modalButton.Text = "Show Modal";
        modalButton.UseVisualStyleBackColor = true;
        modalButton.Click += showButton_Click;
        // 
        // modelessButton
        // 
        modelessButton.Location = new Point(73, 285);
        modelessButton.Name = "modelessButton";
        modelessButton.Size = new Size(250, 29);
        modelessButton.TabIndex = 2;
        modelessButton.Text = "Show Modeless";
        modelessButton.UseVisualStyleBackColor = true;
        modelessButton.Click += modelessButton_Click;
        // 
        // nameTextBox
        // 
        nameTextBox.Location = new Point(73, 63);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(250, 27);
        nameTextBox.TabIndex = 3;
        // 
        // ageTextBox
        // 
        ageTextBox.Location = new Point(73, 147);
        ageTextBox.Name = "ageTextBox";
        ageTextBox.Size = new Size(250, 27);
        ageTextBox.TabIndex = 4;
        ageTextBox.TextChanged += ageTextBox_TextChanged;
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(73, 40);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(49, 20);
        nameLabel.TabIndex = 5;
        nameLabel.Text = "&Name";
        // 
        // ageLabel
        // 
        ageLabel.AutoSize = true;
        ageLabel.Location = new Point(73, 124);
        ageLabel.Name = "ageLabel";
        ageLabel.Size = new Size(36, 20);
        ageLabel.TabIndex = 6;
        ageLabel.Text = "&Age";
        // 
        // staticTestLabel
        // 
        staticTestLabel.BorderStyle = BorderStyle.FixedSingle;
        staticTestLabel.Location = new Point(73, 358);
        staticTestLabel.Name = "staticTestLabel";
        staticTestLabel.Size = new Size(250, 25);
        staticTestLabel.TabIndex = 8;
        staticTestLabel.Text = "Person created: 0";
        // 
        // oddCheckBox
        // 
        oddCheckBox.AutoSize = true;
        oddCheckBox.Enabled = false;
        oddCheckBox.Location = new Point(346, 149);
        oddCheckBox.Name = "oddCheckBox";
        oddCheckBox.Size = new Size(58, 24);
        oddCheckBox.TabIndex = 9;
        oddCheckBox.Text = "odd";
        oddCheckBox.UseVisualStyleBackColor = true;
        // 
        // evenCheckBox
        // 
        evenCheckBox.AutoSize = true;
        evenCheckBox.Enabled = false;
        evenCheckBox.Location = new Point(410, 149);
        evenCheckBox.Name = "evenCheckBox";
        evenCheckBox.Size = new Size(62, 24);
        evenCheckBox.TabIndex = 10;
        evenCheckBox.Text = "even";
        evenCheckBox.UseVisualStyleBackColor = true;
        // 
        // colorButton
        // 
        colorButton.Location = new Point(491, 285);
        colorButton.Name = "colorButton";
        colorButton.Size = new Size(150, 29);
        colorButton.TabIndex = 11;
        colorButton.Text = "Color Demo";
        colorButton.UseVisualStyleBackColor = true;
        colorButton.Click += colorButton_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(491, 40);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(336, 224);
        listBox1.Sorted = true;
        listBox1.TabIndex = 12;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // animalButton
        // 
        animalButton.Location = new Point(677, 285);
        animalButton.Name = "animalButton";
        animalButton.Size = new Size(150, 29);
        animalButton.TabIndex = 13;
        animalButton.Text = "Animal Demo";
        animalButton.UseVisualStyleBackColor = true;
        animalButton.Click += animalButton_Click;
        // 
        // interfaceButton
        // 
        interfaceButton.Location = new Point(491, 354);
        interfaceButton.Name = "interfaceButton";
        interfaceButton.Size = new Size(150, 29);
        interfaceButton.TabIndex = 14;
        interfaceButton.Text = "Interface Demo 1";
        interfaceButton.UseVisualStyleBackColor = true;
        interfaceButton.Click += interfaceButton_Click;
        // 
        // interface2Button
        // 
        interface2Button.Location = new Point(677, 355);
        interface2Button.Name = "interface2Button";
        interface2Button.Size = new Size(150, 29);
        interface2Button.TabIndex = 15;
        interface2Button.Text = "Interface Demo 2";
        interface2Button.UseVisualStyleBackColor = true;
        interface2Button.Click += interface2Button_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(907, 431);
        Controls.Add(interface2Button);
        Controls.Add(interfaceButton);
        Controls.Add(animalButton);
        Controls.Add(listBox1);
        Controls.Add(colorButton);
        Controls.Add(evenCheckBox);
        Controls.Add(oddCheckBox);
        Controls.Add(staticTestLabel);
        Controls.Add(ageLabel);
        Controls.Add(nameLabel);
        Controls.Add(ageTextBox);
        Controls.Add(nameTextBox);
        Controls.Add(modelessButton);
        Controls.Add(modalButton);
        Name = "MainForm";
        Text = "Main Form";
        Load += MainForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button modalButton;
    private Button modelessButton;
    private TextBox nameTextBox;
    private TextBox ageTextBox;
    private Label nameLabel;
    private Label ageLabel;
    private Label staticTestLabel;
    private CheckBox oddCheckBox;
    private CheckBox evenCheckBox;
    private Button colorButton;
    private ListBox listBox1;
    private Button animalButton;
    private Button interfaceButton;
    private Button interface2Button;
}
