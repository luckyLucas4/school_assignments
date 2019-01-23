#pragma once

namespace CppWinForm1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
		int Minute = 0;
		int Second = 0;
		String^ min;
		String^ sec;

	private: System::Windows::Forms::Label^  lblTime;

	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  btnRektangel;
	private: System::Windows::Forms::Button^  btnEllipse;
	private: System::Windows::Forms::Timer^  Timer;
	private: System::ComponentModel::IContainer^  components;
	protected:

	protected:

	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			this->btnRektangel = (gcnew System::Windows::Forms::Button());
			this->btnEllipse = (gcnew System::Windows::Forms::Button());
			this->Timer = (gcnew System::Windows::Forms::Timer(this->components));
			this->lblTime = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// btnRektangel
			// 
			this->btnRektangel->Location = System::Drawing::Point(99, 66);
			this->btnRektangel->Name = L"btnRektangel";
			this->btnRektangel->Size = System::Drawing::Size(148, 45);
			this->btnRektangel->TabIndex = 0;
			this->btnRektangel->Text = L"Rektangel";
			this->btnRektangel->UseVisualStyleBackColor = true;
			this->btnRektangel->Click += gcnew System::EventHandler(this, &MyForm::btnRektangel_Click);
			// 
			// btnEllipse
			// 
			this->btnEllipse->Location = System::Drawing::Point(400, 66);
			this->btnEllipse->Name = L"btnEllipse";
			this->btnEllipse->Size = System::Drawing::Size(172, 45);
			this->btnEllipse->TabIndex = 1;
			this->btnEllipse->Text = L"Ellips";
			this->btnEllipse->UseVisualStyleBackColor = true;
			this->btnEllipse->Click += gcnew System::EventHandler(this, &MyForm::btnEllipse_Click);
			// 
			// Timer
			// 
			this->Timer->Enabled = true;
			this->Timer->Interval = 1000;
			this->Timer->Tick += gcnew System::EventHandler(this, &MyForm::Timer_Tick);
			// 
			// lblTime
			// 
			this->lblTime->AutoSize = true;
			this->lblTime->Location = System::Drawing::Point(62, 457);
			this->lblTime->Name = L"lblTime";
			this->lblTime->Size = System::Drawing::Size(28, 17);
			this->lblTime->TabIndex = 2;
			this->lblTime->Text = L"0:0";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(682, 555);
			this->Controls->Add(this->lblTime);
			this->Controls->Add(this->btnEllipse);
			this->Controls->Add(this->btnRektangel);
			this->Margin = System::Windows::Forms::Padding(4);
			this->Name = L"MyForm";
			this->Text = L"Graphics";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	bool shape = true;

	private: System::Void btnRektangel_Click(System::Object^  sender, System::EventArgs^  e) {
		shape = true;
		Invalidate();
	}

	private: System::Void btnEllipse_Click(System::Object^  sender, System::EventArgs^  e) {
		shape = false;
		Invalidate();
	}

	public: virtual System::Void MyForm::OnPaint(PaintEventArgs^ e) override 
	{

		Graphics^ g = e->Graphics;

		Pen^ pen = gcnew Pen(Color::Black);

		SolidBrush^ brush = gcnew SolidBrush(Color::Blue);

		if (shape) {
			brush->Color = Color::Red;
			g->FillRectangle(brush, 250,200, 200, 200);
		}
		else {
			brush->Color = Color::Blue;
			g->FillEllipse(brush, 250, 200, 200, 200);
		}
		g->DrawRectangle(pen, 250, 200, 200, 200);
	}
	private: System::Void Timer_Tick(System::Object^  sender, System::EventArgs^  e) {

		Second++;
		if (Second == 60) {
			Minute++;
			Second = 0;
		}

		min = Convert::ToString(Minute);
		sec = Convert::ToString(Second);

		lblTime->Text = min + ":" + sec;

	}
};
}