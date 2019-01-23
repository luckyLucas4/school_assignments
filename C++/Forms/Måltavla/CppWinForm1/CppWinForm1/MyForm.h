#pragma once
#include "Target.h"
#include "Aim.h"
#include "Shot.h"
#include <vector>
#include <cmath>
#include <cstdlib>

namespace CppWinForm1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace std;

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

	private: System::Windows::Forms::PictureBox^  pcbTarget;
	private: System::Windows::Forms::NumericUpDown^  numRadius;
	private: System::Windows::Forms::TrackBar^  trackBarX;
	private: System::Windows::Forms::TrackBar^  trackBarY;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::NumericUpDown^  numRings;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  lblShots;
	private: System::Windows::Forms::Timer^  timer;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  lblPoints;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  lblTotal;
	private: System::Windows::Forms::NumericUpDown^  numSpeed;

	private: System::Windows::Forms::Label^  label6;


	private: System::ComponentModel::IContainer^  components;



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
			this->pcbTarget = (gcnew System::Windows::Forms::PictureBox());
			this->numRadius = (gcnew System::Windows::Forms::NumericUpDown());
			this->trackBarX = (gcnew System::Windows::Forms::TrackBar());
			this->trackBarY = (gcnew System::Windows::Forms::TrackBar());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->numRings = (gcnew System::Windows::Forms::NumericUpDown());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->lblShots = (gcnew System::Windows::Forms::Label());
			this->timer = (gcnew System::Windows::Forms::Timer(this->components));
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->lblPoints = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->lblTotal = (gcnew System::Windows::Forms::Label());
			this->numSpeed = (gcnew System::Windows::Forms::NumericUpDown());
			this->label6 = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pcbTarget))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numRadius))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBarX))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBarY))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numRings))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numSpeed))->BeginInit();
			this->SuspendLayout();
			// 
			// pcbTarget
			// 
			this->pcbTarget->Enabled = false;
			this->pcbTarget->Location = System::Drawing::Point(214, 135);
			this->pcbTarget->Name = L"pcbTarget";
			this->pcbTarget->Size = System::Drawing::Size(140, 146);
			this->pcbTarget->TabIndex = 0;
			this->pcbTarget->TabStop = false;
			this->pcbTarget->Visible = false;
			// 
			// numRadius
			// 
			this->numRadius->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 16.2F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->numRadius->Increment = System::Decimal(gcnew cli::array< System::Int32 >(4) { 10, 0, 0, 0 });
			this->numRadius->Location = System::Drawing::Point(12, 54);
			this->numRadius->Maximum = System::Decimal(gcnew cli::array< System::Int32 >(4) { 1000, 0, 0, 0 });
			this->numRadius->Name = L"numRadius";
			this->numRadius->Size = System::Drawing::Size(79, 38);
			this->numRadius->TabIndex = 5;
			this->numRadius->ValueChanged += gcnew System::EventHandler(this, &MyForm::numRadius_ValueChanged);
			// 
			// trackBarX
			// 
			this->trackBarX->LargeChange = 7;
			this->trackBarX->Location = System::Drawing::Point(111, 17);
			this->trackBarX->Maximum = 780;
			this->trackBarX->Minimum = 80;
			this->trackBarX->Name = L"trackBarX";
			this->trackBarX->Size = System::Drawing::Size(633, 56);
			this->trackBarX->SmallChange = 10;
			this->trackBarX->TabIndex = 6;
			this->trackBarX->TickFrequency = 0;
			this->trackBarX->Value = 100;
			this->trackBarX->Scroll += gcnew System::EventHandler(this, &MyForm::trackBarX_Scroll);
			// 
			// trackBarY
			// 
			this->trackBarY->Location = System::Drawing::Point(24, 252);
			this->trackBarY->Maximum = 650;
			this->trackBarY->Minimum = 80;
			this->trackBarY->Name = L"trackBarY";
			this->trackBarY->Orientation = System::Windows::Forms::Orientation::Vertical;
			this->trackBarY->RightToLeft = System::Windows::Forms::RightToLeft::Yes;
			this->trackBarY->Size = System::Drawing::Size(56, 391);
			this->trackBarY->SmallChange = 10;
			this->trackBarY->TabIndex = 7;
			this->trackBarY->TickFrequency = 0;
			this->trackBarY->Value = 650;
			this->trackBarY->Scroll += gcnew System::EventHandler(this, &MyForm::trackBarY_Scroll);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(19, 17);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(74, 25);
			this->label1->TabIndex = 8;
			this->label1->Text = L"Radie:";
			// 
			// numRings
			// 
			this->numRings->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->numRings->Location = System::Drawing::Point(24, 135);
			this->numRings->Maximum = System::Decimal(gcnew cli::array< System::Int32 >(4) { 15, 0, 0, 0 });
			this->numRings->Name = L"numRings";
			this->numRings->Size = System::Drawing::Size(56, 30);
			this->numRings->TabIndex = 9;
			this->numRings->Value = System::Decimal(gcnew cli::array< System::Int32 >(4) { 5, 0, 0, 0 });
			this->numRings->ValueChanged += gcnew System::EventHandler(this, &MyForm::numRings_ValueChanged);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10.2F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label2->Location = System::Drawing::Point(21, 105);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(63, 20);
			this->label2->TabIndex = 10;
			this->label2->Text = L"Ringar:";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label3->Location = System::Drawing::Point(558, 54);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(130, 25);
			this->label3->TabIndex = 11;
			this->label3->Text = L"Skjutna skott:";
			// 
			// lblShots
			// 
			this->lblShots->AutoSize = true;
			this->lblShots->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lblShots->Location = System::Drawing::Point(694, 54);
			this->lblShots->Name = L"lblShots";
			this->lblShots->Size = System::Drawing::Size(23, 25);
			this->lblShots->TabIndex = 12;
			this->lblShots->Text = L"0";
			// 
			// timer
			// 
			this->timer->Enabled = true;
			this->timer->Interval = 5;
			this->timer->Tick += gcnew System::EventHandler(this, &MyForm::timer_Tick);
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label4->Location = System::Drawing::Point(515, 90);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(173, 25);
			this->label4->TabIndex = 11;
			this->label4->Text = L"Senaste poängen:";
			// 
			// lblPoints
			// 
			this->lblPoints->AutoSize = true;
			this->lblPoints->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lblPoints->Location = System::Drawing::Point(694, 90);
			this->lblPoints->Name = L"lblPoints";
			this->lblPoints->Size = System::Drawing::Size(23, 25);
			this->lblPoints->TabIndex = 12;
			this->lblPoints->Text = L"0";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label5->Location = System::Drawing::Point(621, 126);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(67, 25);
			this->label5->TabIndex = 11;
			this->label5->Text = L"Totalt:";
			// 
			// lblTotal
			// 
			this->lblTotal->AutoSize = true;
			this->lblTotal->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->lblTotal->Location = System::Drawing::Point(694, 126);
			this->lblTotal->Name = L"lblTotal";
			this->lblTotal->Size = System::Drawing::Size(23, 25);
			this->lblTotal->TabIndex = 12;
			this->lblTotal->Text = L"0";
			// 
			// numSpeed
			// 
			this->numSpeed->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->numSpeed->Location = System::Drawing::Point(24, 216);
			this->numSpeed->Name = L"numSpeed";
			this->numSpeed->Size = System::Drawing::Size(56, 30);
			this->numSpeed->TabIndex = 9;
			this->numSpeed->Value = System::Decimal(gcnew cli::array< System::Int32 >(4) { 2, 0, 0, 0 });
			this->numSpeed->ValueChanged += gcnew System::EventHandler(this, &MyForm::numSpeed_ValueChanged);
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10.2F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label6->Location = System::Drawing::Point(8, 181);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(86, 20);
			this->label6->TabIndex = 10;
			this->label6->Text = L"Hastighet:";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(782, 655);
			this->Controls->Add(this->lblTotal);
			this->Controls->Add(this->lblPoints);
			this->Controls->Add(this->lblShots);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->numSpeed);
			this->Controls->Add(this->numRings);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->trackBarY);
			this->Controls->Add(this->trackBarX);
			this->Controls->Add(this->numRadius);
			this->Controls->Add(this->pcbTarget);
			this->DoubleBuffered = true;
			this->KeyPreview = true;
			this->Margin = System::Windows::Forms::Padding(4);
			this->Name = L"MyForm";
			this->Text = L"Måltavla";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->KeyDown += gcnew System::Windows::Forms::KeyEventHandler(this, &MyForm::MyForm_KeyDown);
			this->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::MyForm_MouseClick);
			this->MouseMove += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::MyForm_MouseMove);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pcbTarget))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numRadius))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBarX))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBarY))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numRings))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->numSpeed))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

		// Deklarerar instanser av klasserna Target och Aim

		Target^ target = gcnew Target();
		Aim^ playerAim = gcnew Aim();

		// Deklarar ett skott
		Shot^ shot;
		// För att se om skottet ska ritas
		bool shotActive = false;
		// Antalet skutna skott
		int shots = 0;


	// Körs direkt när programmet startar
	private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) {

		// Sätter koordinaterna på måltavlan till samma som bildrutan, 
		target->x = pcbTarget->Location.X;
		target->y = pcbTarget->Location.Y;

		// och justerar dragreglagen till de värdena
		trackBarX->Value = (int)target->x;
		trackBarY->Value = 700 - (int)target->y; // (dras från maxvärdet så att reglaget startar vid toppen)

		// Radien justeras efter bildrutan, nummerväljaren tar emot det värdet
		target->radius = pcbTarget->Size.Height / 2;
		int x = target->radius;
		numRadius->Value = x;

		// Antalet ringar justeras efter nummerväljarens värde
		target->parts = (float)numRings->Value;

		// Justerar måltavlans fart efter nummerväljaren
		int speed = Convert::ToInt32(numSpeed->Value);
		target->dx = speed;
		target->dy = speed;

		// Startpositionen för siktet
		playerAim->x = 400;
		playerAim->y = 350;

		// Skapar ett temporärt skott
		shot = gcnew Shot(gcnew Point(0, 0));
	}

	// När skärmen ska ritas kallar programmet på klassernas egna funktioner
	public: virtual System::Void MyForm::OnPaint(PaintEventArgs^ e) override {

		target->Draw(e->Graphics);

		playerAim->Draw(e->Graphics);

		if (shotActive) {
			shot->Draw(e->Graphics);
		}
	}

	// Den övre nummerväljaren ändrar måltavlans radie
	private: System::Void numRadius_ValueChanged(System::Object^  sender, System::EventArgs^  e) {
		target->radius = (float)numRadius->Value;
		// och fönstret ritas om
		Invalidate();
	}

	// X-koordinaten justeras efter det övre dragreglaget
	private: System::Void trackBarX_Scroll(System::Object^  sender, System::EventArgs^  e) {
		target->x = (float)(trackBarX->Value);
		Invalidate();
	}

	// Y-koordinaten justeras efter det vänstra dragreglaget (inverterat pga max - värdet)
	private: System::Void trackBarY_Scroll(System::Object^  sender, System::EventArgs^  e) {
		target->y = trackBarY->Maximum - (float)(trackBarY->Value);
		Invalidate();
	}

	// Den mittersta nummerväljaren ändrar antalet ringar
	private: System::Void numRings_ValueChanged(System::Object^  sender, System::EventArgs^  e) {
		target->parts = (float)numRings->Value;
		Invalidate();
	}

	// Den nedersta nummerväljaren ändrar farten
	private: System::Void numSpeed_ValueChanged(System::Object^  sender, System::EventArgs^  e) {
		// Konverterar farten till en int
		int speed = Convert::ToInt32(numSpeed->Value);

		// Ändrar måltavlans hastighet
		// (om den nuvarande hastigheten är negativ ska den förtsätta vara det)
		if (target->dx < 0) {
			target->dx = -speed;
		}
		else {
			target->dx = speed;
		}

		if (target->dy < 0) {
			target->dy = -speed;
		}
		else {
			target->dy = speed;
		}
	}

	private: System::Void MyForm_KeyDown(System::Object^  sender, System::Windows::Forms::KeyEventArgs^  e) {
		// Anropar funktionen KeyDown i siktet
		int keyValue = playerAim->KeyDown(e);
		// En 1:a betyder att koordinaterna har ändrats
		if (keyValue == 1) {
			// Fönstret ritas bara om ifall siktet har flyttats
			Invalidate();
		}
		// En 2:a betyder att mellanslag är tryckt
		else if (keyValue == 2) {
			// Anropar Shoot-funktionen 
			Shoot();
		}
	}

	 // När musen flyttas
	private: System::Void MyForm_MouseMove(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
		// MouseMove funktionen på siktet anropas, en MouseEventArgs med information skickas med
		playerAim->MouseMove(e);
		Invalidate();
	}

	// När musen klickar
	private: System::Void MyForm_MouseClick(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) {
		// Anropar Shoot-funktionen
		Shoot();
	}
	
	// Här hanteras ett anrop på att ett skott ska skapas
	private: void Shoot() {
		
		// En ny punkt skapas genom funktionen på siktet
		Point^ pos = playerAim->Shoot();
		shot = gcnew Shot(pos);
		shot->active = true;

		// Det booleanska värdet hitTarget på skottet tar emot ett värde från OnTarget-funktionen
		// på måltavlan. Funktionen ger även ett nytt värde till poängen genom en referensparameter
		int points = 0;
		shot->hitTarget = target->OnTarget(pos, points);

		// Poängen uppdateras på skärmen
		lblPoints->Text = Convert::ToString(points);
		lblTotal->Text = Convert::ToString(Convert::ToInt32(lblTotal->Text) + points);

		// Antalet skott uppdateras på skärmen, hastigheten på måltavlan ökar
		shots++;
		lblShots->Text = Convert::ToString(shots);
		numSpeed->Value++;
		
		// Meddelar att ett skott har skapats
		shotActive = true;
	}

	// Den här funktionen körs var 5:e millisekund
	private: System::Void timer_Tick(System::Object^  sender, System::EventArgs^  e) {

		// Koordinaterna på måltavlan ändras i rätt riktning 
		target->x += target->dx;
		// Om det senaste skottet träffade tavlan ändras även dess koordinater med samma värde
		if (shot->hitTarget) {
			shot->x += target->dx;
		}
		// Om ytterkanten på tavlan är utanför gränserna för tillåtna värden ställs de tillbaks
		// och hastigheten inverteras
		if (target->x + target->radius * 2 >= trackBarX->Maximum ) {
			target->x = trackBarX->Maximum - target->radius*2;
			target->dx = -target->dx;
		}
		else if (target->x <= trackBarX->Minimum) {
			target->x = trackBarX->Minimum;
			target->dx = -target->dx;
		}

		// Samma procedur i höjdled
		target->y += target->dy;
		if (shot->hitTarget) {
			shot->y += target->dy;
		}
		if (target->y + target->radius * 2 >= trackBarY->Maximum) {
			target->y = trackBarY->Maximum - target->radius*2;
			target->dy = -target->dy;
		}
		else if (target->y <= trackBarY->Minimum) {
			target->y = trackBarY->Minimum;
			target->dy = -target->dy;
		}
		// Använd inte det här
		//target->parts++;
		//if (target->parts >= 15) {
		//	target->parts = 3;
		//}
		// Värdena på dragreglaget uppdateras
		trackBarX->Value = Convert::ToInt32(target->x);
		trackBarY->Value = Convert::ToInt32(target->y);
		Invalidate();
	}

};
}
