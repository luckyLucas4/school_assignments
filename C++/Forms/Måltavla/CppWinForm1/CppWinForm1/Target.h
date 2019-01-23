#pragma once
#include <cstdlib>
#include <cmath>

using namespace System::Drawing;
using namespace System;
ref class Target 
{
public:
	// Deklarerar variabler
	float x, y, radius, parts;
	int dx, dy;

	// Avgör om punkten finns på tavlan, ger en poäng beroende på hur när mitten skottet träffade
	bool OnTarget(Point^ p, int& points) {
		// Formeln för avståndet från mitten av tavlan till punkten
		int distance = std::sqrt(pow(((y + radius) - p->Y), 2) + pow(((x + radius) - p->X), 2));
		// Mitt i ger 200 poäng 
		if (distance == 0) {
			points == 200;
			return true;
		}
		// Om avståndet från mitten är mindre än radien
		else if (distance <= radius) {
			// Höjden på varje av de fem zonerna
			int zoneWidth = Convert::ToInt32(radius / 5);
			// Räknar ut vilken zon som punkten ligger i 
			int zone = distance / zoneWidth;
			// 20 dras bort för varje zon bort från mitten
			points = 100 - zone * 20 ;
			return true;
		}		
		// Om skottet inte har träffat måltavlan
		return false;
	}

	// Körs när fönstret ska ritas om
	void Draw(Graphics^ g) {
		// Pennan används för att rita kanten på måltavlan
		Pen^ pen = gcnew Pen(Color::Black,5);

		// Penseln som ritar ringarna
		SolidBrush^ b = gcnew SolidBrush(Color::White);

		// Ett fält med färger som kan användas till penseln
		array<Color>^ colors = { Color::DarkRed, Color::Yellow, Color::Red, Color::Blue, Color::Black, Color::Aquamarine, Color::SandyBrown, Color::DarkSalmon, Color::Brown, Color::Green, Color::Orange, Color::MediumSpringGreen, Color::Bisque, Color::PaleGreen, Color::Turquoise, Color::Sienna};

		// Rektangeln där cirkeln ska ritas
		int rad = Convert::ToInt32(2 * this->radius);
		Rectangle^ drawTarget = gcnew Rectangle(
			Convert::ToInt32(this->x),
			Convert::ToInt32(this->y),
			rad, rad);

		// Ritar den svarta kanten och den yttersta vita ringen
		g->DrawEllipse(pen, drawTarget->X, drawTarget->Y, drawTarget->Width, drawTarget->Height);
		g->FillEllipse(b, drawTarget->X, drawTarget->Y, drawTarget->Width, drawTarget->Height);

		// Loopar en gång för varje cirkel som ska ritas
		for (int i = (int)(this->parts - 1); i > 0; i--)
		{
			// Koordinaterna för ringen flyttas åt höger och nedåt varje gång loopen körs 
			// justerat efter antalet ringar
			drawTarget->X += this->radius * 1/this->parts;
			drawTarget->Y += this->radius * 1/this->parts;
			// Radien minskar baserat på antalet ringar som ska ritas
			drawTarget->Width = this->radius * 2 * (float)(i / this->parts);
			drawTarget->Height = drawTarget->Width;
			// Penseln får nästa färg i fältet
			b->Color = colors[i-1];
			// Cirkeln ritas med de nya värdena som nu har satts
			g->FillEllipse(b, drawTarget->X, drawTarget->Y, drawTarget->Width, drawTarget->Height);
		}
	}
};