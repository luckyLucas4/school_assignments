#pragma once
using namespace System::Windows::Forms;
using namespace System::Drawing;
ref class Aim
{
public:

	// Deklarerar variabler för koordinaterna, samt sätter bredden till 30	
	int x, y;
	int width = 30;


	// Tar emot ett KeyEventArgs när en knapp har tryckts ner
	int KeyDown(System::Windows::Forms::KeyEventArgs^  e)
	{
		// Kollar om knappen är D, A, S eller W, isåfall flyttas koordinaterna 
		// i den riktningen och 1 skickas i retur
		if (e->KeyCode == Keys::D) {
			MoveAimRight(40);
			return 1;
		}
		if (e->KeyCode == Keys::A) {
			MoveAimRight(-40);
			return 1;
		}
		if (e->KeyCode == Keys::S) {
			MoveAimDown(40);
			return 1;
		}
		if (e->KeyCode == Keys::W) {
			MoveAimDown(-40);
			return 1;
		}
		if (e->KeyCode == Keys::Space) {
			Shoot();
			return 2;
		}
		// Om ingen knapp matchar skickas 0 
		return 0;
	}

	// Justerar x-koordinaten
	void MoveAimRight(int step) {
		x += step;
	}
	// Justerar y-koordinaten
	void MoveAimDown(int step) {
		y += step;
	}

	// Koordinaterna följer musen, anpassat så att musen är mitten av siktet
	void MouseMove(MouseEventArgs^ e) {
		x = e->Location.X - width / 2;
		y = e->Location.Y - width / 2;
	}
	
	// Anropas när musen klickas eller mellanslag trycks ner
	Point^ Shoot() {
		// Returnerar ett nytt skott
		return gcnew Point(x, y);
	}

	// Anropas när fönstret ska ritas om
	void Draw(Graphics^ g) {

		// En tunn vit penna och en tjock svart penna
		Pen^ p1 = gcnew Pen(Color::White, 1);
		Pen^ p2 = gcnew Pen(Color::Black, 5);

		// En ring ritas i svart med koordinaterna och bredden
		g->DrawEllipse(p2, x, y, width, width);

		// Linjer dras horisontellt och vertikalt för att skapa ett kors mitt i ringen
		g->DrawLine(p2, x, y + width / 2, x + width, y + width / 2);
		g->DrawLine(p2, x + width / 2, y, x + width / 2, y + width);

		// Samma process upprepas med den tunnare vita pennan ovanpå den svarta figuren
		g->DrawEllipse(p1, x, y, width, width);

		g->DrawLine(p1, x, y + width / 2, x + width, y + width / 2);
		g->DrawLine(p1, x + width / 2, y, x + width / 2, y + width);

	}
};