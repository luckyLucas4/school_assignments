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
	private: System::Windows::Forms::Label^  lblNumber;
	private: System::Windows::Forms::Button^  btnIncrease;
	private: System::Windows::Forms::Button^  btnDecrease;

	private: System::Windows::Forms::Label^  lblSquare;
	private: System::Windows::Forms::Label^  label2;






	protected:


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
			this->lblNumber = (gcnew System::Windows::Forms::Label());
			this->btnIncrease = (gcnew System::Windows::Forms::Button());
			this->btnDecrease = (gcnew System::Windows::Forms::Button());
			this->lblSquare = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10.2F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(144, 39);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(129, 20);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Enter a number:";
			// 
			// lblNumber
			// 
			this->lblNumber->AutoSize = true;
			this->lblNumber->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 16.2F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lblNumber->Location = System::Drawing::Point(192, 94);
			this->lblNumber->Name = L"lblNumber";
			this->lblNumber->Size = System::Drawing::Size(31, 32);
			this->lblNumber->TabIndex = 1;
			this->lblNumber->Text = L"0";
			// 
			// btnIncrease
			// 
			this->btnIncrease->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 13.8F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnIncrease->Location = System::Drawing::Point(292, 94);
			this->btnIncrease->Name = L"btnIncrease";
			this->btnIncrease->Size = System::Drawing::Size(44, 38);
			this->btnIncrease->TabIndex = 2;
			this->btnIncrease->Text = L">";
			this->btnIncrease->UseVisualStyleBackColor = true;
			this->btnIncrease->Click += gcnew System::EventHandler(this, &MyForm::btnIncrease_Click);
			// 
			// btnDecrease
			// 
			this->btnDecrease->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 13.8F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->btnDecrease->ForeColor = System::Drawing::Color::Black;
			this->btnDecrease->Location = System::Drawing::Point(77, 94);
			this->btnDecrease->Name = L"btnDecrease";
			this->btnDecrease->Size = System::Drawing::Size(48, 38);
			this->btnDecrease->TabIndex = 3;
			this->btnDecrease->Text = L"<";
			this->btnDecrease->UseVisualStyleBackColor = true;
			this->btnDecrease->Click += gcnew System::EventHandler(this, &MyForm::btnDecrease_Click);
			// 
			// lblSquare
			// 
			this->lblSquare->AutoSize = true;
			this->lblSquare->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 16.2F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lblSquare->Location = System::Drawing::Point(192, 196);
			this->lblSquare->Name = L"lblSquare";
			this->lblSquare->Size = System::Drawing::Size(31, 32);
			this->lblSquare->TabIndex = 5;
			this->lblSquare->Text = L"0";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10.2F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label2->Location = System::Drawing::Point(171, 153);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(67, 20);
			this->label2->TabIndex = 6;
			this->label2->Text = L"Square:";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(413, 260);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->lblSquare);
			this->Controls->Add(this->btnDecrease);
			this->Controls->Add(this->btnIncrease);
			this->Controls->Add(this->lblNumber);
			this->Controls->Add(this->label1);
			this->Margin = System::Windows::Forms::Padding(4);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void btnDecrease_Click(System::Object^  sender, System::EventArgs^  e) {
		int num = Convert::ToInt32(lblNumber->Text);
		num--;
		lblNumber->Text = Convert::ToString(num);
		num *= num;
		lblSquare->Text = Convert::ToString(num);
	}
	private: System::Void btnIncrease_Click(System::Object^  sender, System::EventArgs^  e) {
		int num = Convert::ToInt32(lblNumber->Text);
		num++;
		lblNumber->Text = Convert::ToString(num);
		num *= num;
		lblSquare->Text = Convert::ToString(num);
	}
	private: System::Void btnSquare_Click(System::Object^  sender, System::EventArgs^  e) {
		int num = Convert::ToInt32(lblNumber->Text);
		num *= num;
		lblSquare->Text = Convert::ToString(num);
	}

};
}
