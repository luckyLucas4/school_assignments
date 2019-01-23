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
	private: System::Windows::Forms::Label^  label1;
	protected:





	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::NumericUpDown^  num1;
	private: System::Windows::Forms::NumericUpDown^  num2;
	private: System::Windows::Forms::NumericUpDown^  num3;
	private: System::Windows::Forms::NumericUpDown^  num4;
	private: System::Windows::Forms::NumericUpDown^  num5;






	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->num1 = (gcnew System::Windows::Forms::NumericUpDown());
			this->num2 = (gcnew System::Windows::Forms::NumericUpDown());
			this->num3 = (gcnew System::Windows::Forms::NumericUpDown());
			this->num4 = (gcnew System::Windows::Forms::NumericUpDown());
			this->num5 = (gcnew System::Windows::Forms::NumericUpDown());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->num1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->num2))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->num3))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->num4))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->num5))->BeginInit();
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(109, 56);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(133, 25);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Mata in heltal:";
			// 
			// button1
			// 
			this->button1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button1->Location = System::Drawing::Point(114, 347);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(128, 59);
			this->button1->TabIndex = 2;
			this->button1->Text = L"Sortera!";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// num1
			// 
			this->num1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num1->Location = System::Drawing::Point(144, 105);
			this->num1->Name = L"num1";
			this->num1->Size = System::Drawing::Size(69, 30);
			this->num1->TabIndex = 3;
			// 
			// num2
			// 
			this->num2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num2->Location = System::Drawing::Point(144, 152);
			this->num2->Name = L"num2";
			this->num2->Size = System::Drawing::Size(69, 30);
			this->num2->TabIndex = 3;
			// 
			// num3
			// 
			this->num3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num3->Location = System::Drawing::Point(144, 197);
			this->num3->Name = L"num3";
			this->num3->Size = System::Drawing::Size(69, 30);
			this->num3->TabIndex = 3;
			// 
			// num4
			// 
			this->num4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num4->Location = System::Drawing::Point(144, 244);
			this->num4->Name = L"num4";
			this->num4->Size = System::Drawing::Size(69, 30);
			this->num4->TabIndex = 3;
			// 
			// num5
			// 
			this->num5->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num5->Location = System::Drawing::Point(144, 290);
			this->num5->Name = L"num5";
			this->num5->Size = System::Drawing::Size(69, 30);
			this->num5->TabIndex = 3;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(348, 446);
			this->Controls->Add(this->num5);
			this->Controls->Add(this->num4);
			this->Controls->Add(this->num3);
			this->Controls->Add(this->num2);
			this->Controls->Add(this->num1);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->label1);
			this->Margin = System::Windows::Forms::Padding(4);
			this->Name = L"MyForm";
			this->Text = L"Sortering";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->num1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->num2))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->num3))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->num4))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->num5))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
		int values[5] = {
			Convert::ToInt32(num1->Value),
			Convert::ToInt32(num2->Value),
			Convert::ToInt32(num3->Value),
			Convert::ToInt32(num4->Value),
			Convert::ToInt32(num5->Value)
		};
		int temp;
		for (int i = 1; i < 5; i++) {
			int n = i;
			while (values[n] < values[n - 1] && n > 0) {
				temp = values[n];
				values[n] = values[n - 1];
				values[n - 1] = temp;
				n--;
			}
		}
		num1->Value = values[0];
		num2->Value = values[1];
		num3->Value = values[2];
		num4->Value = values[3];
		num5->Value = values[4];
	}
};
}
