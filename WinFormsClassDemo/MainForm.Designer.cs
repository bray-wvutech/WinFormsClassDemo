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
        mainDateTimePicker = new DateTimePicker();
        showButton = new Button();
        modelessButton = new Button();
        SuspendLayout();
        // 
        // mainDateTimePicker
        // 
        mainDateTimePicker.Location = new Point(73, 67);
        mainDateTimePicker.Name = "mainDateTimePicker";
        mainDateTimePicker.Size = new Size(250, 27);
        mainDateTimePicker.TabIndex = 0;
        // 
        // showButton
        // 
        showButton.Location = new Point(73, 158);
        showButton.Name = "showButton";
        showButton.Size = new Size(250, 29);
        showButton.TabIndex = 1;
        showButton.Text = "Modal Date";
        showButton.UseVisualStyleBackColor = true;
        showButton.Click += showButton_Click;
        // 
        // modelessButton
        // 
        modelessButton.Location = new Point(73, 234);
        modelessButton.Name = "modelessButton";
        modelessButton.Size = new Size(250, 29);
        modelessButton.TabIndex = 2;
        modelessButton.Text = "Modeless Date";
        modelessButton.UseVisualStyleBackColor = true;
        modelessButton.Click += modelessButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(403, 398);
        Controls.Add(modelessButton);
        Controls.Add(showButton);
        Controls.Add(mainDateTimePicker);
        Name = "MainForm";
        Text = "Main Form";
        Load += MainForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private DateTimePicker mainDateTimePicker;
    private Button showButton;
    private Button modelessButton;
}
