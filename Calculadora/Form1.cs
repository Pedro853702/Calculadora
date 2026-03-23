namespace Wind;

public partial class Form1 : Form
{
    Label resultado;
    bool Mais_Boll = false;
    bool Menos_Bool = false;
    bool Vezes_Bool = false;
    bool Dividir_Bool = false;
    double Numero_1;
    double Numero_2;
    public Form1()
    {
        InitializeComponent();
        this.Text = "Calculadora";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new Size (550, 900);
        this.BackColor= Color.FromArgb(90,90,90);
        Color CinzaEscuro = Color.FromArgb(60,60,60);
        resultado = new Label();
        resultado.Width = 500;
        resultado.Height = 300;
        resultado.Location = new Point(20,25);
        resultado.BackColor =CinzaEscuro;
        resultado.ForeColor= Color.White;
        resultado.Enabled = false;
        resultado.Text = "";
        resultado.TextAlign = ContentAlignment.MiddleCenter;
        resultado.Font = new Font("Consolas", 20);
        this.Controls.Add(resultado);
        Button Um = new Button();
        Um.Width = 115;
        Um.Height = 80;
        Um.BackColor = CinzaEscuro;
        Um.Text= "1";
        Um.Location = new Point(25, 350);
        Um.Click += Button;
        this.Controls.Add(Um);


        Button Dois = new Button();
        Dois.Width = 115;
        Dois.Height = 80;
        Dois.BackColor = CinzaEscuro;
        Dois.Text= "2";
        Dois.Location = new Point(150, 350);
        Dois.Click += Button;
        this.Controls.Add(Dois);

        Button Tres = new Button();
        Tres.Width = 115;
        Tres.Height = 80;
        Tres.BackColor = CinzaEscuro;
        Tres.Text= "3";
        Tres.Location = new Point(275, 350);
        Tres.Click += Button;
        this.Controls.Add(Tres);

        Button Quatro = new Button();
        Quatro.Width = 115;
        Quatro.Height = 80;
        Quatro.BackColor = CinzaEscuro;
        Quatro.Text= "4";
        Quatro.Location = new Point(25, 450);
        Quatro.Click += Button;
        this.Controls.Add(Quatro);

        Button Cinco = new Button();
        Cinco.Width = 115;
        Cinco.Height = 80;
        Cinco.BackColor = CinzaEscuro;
        Cinco.Text= "5";
        Cinco.Location = new Point(150, 450);
        Cinco.Click += Button;
        this.Controls.Add(Cinco);

        Button Seis = new Button();
        Seis.Width = 115;
        Seis.Height = 80;
        Seis.BackColor = CinzaEscuro;
        Seis.Text= "6";
        Seis.Location = new Point(275, 450);
        Seis.Click += Button;
        this.Controls.Add(Seis);

        Button Sete = new Button();
        Sete.Width = 115;
        Sete.Height = 80;
        Sete.BackColor = CinzaEscuro;
        Sete.Text= "7";
        Sete.Location = new Point(25, 550);
        Sete.Click += Button;
        this.Controls.Add(Sete);

        Button Oito = new Button();
        Oito.Width = 115;
        Oito.Height = 80;
        Oito.BackColor = CinzaEscuro;
        Oito.Text= "8";
        Oito.Location = new Point(150, 550);
        Oito.Click += Button;
        this.Controls.Add(Oito);

        Button Nove = new Button();
        Nove.Width = 115;
        Nove.Height = 80;
        Nove.BackColor = CinzaEscuro;
        Nove.Text= "9";
        Nove.Location = new Point(275, 550);
        Nove.Click += Button;
        this.Controls.Add(Nove);

        Button Zero = new Button();
        Zero.Width = 115;
        Zero.Height = 80;
        Zero.BackColor = CinzaEscuro;
        Zero.Text= "0";
        Zero.Location = new Point(150, 650);
        Zero.Click += Button;
        this.Controls.Add(Zero);

        Button Virgula = new Button();
        Virgula.Width = 115;
        Virgula.Height = 80;
        Virgula.BackColor = CinzaEscuro;
        Virgula.Text= ",";
        Virgula.Location = new Point(150, 750);
        Virgula.Click += Button;
        this.Controls.Add(Virgula);

        Button Igual = new Button();
        Igual.Width = 115;
        Igual.Height = 80;
        Igual.BackColor = CinzaEscuro;
        Igual.Text= "=";
        Igual.Location = new Point(275, 650);
        Igual.Click+=Igual2;
        this.Controls.Add(Igual);
        
        Button C = new Button();
        C.Width = 115;
        C.Height = 80;
        C.BackColor = CinzaEscuro;
        C.Text= "C";
        C.Location = new Point(25, 650);
        C.Click+=C2;
        this.Controls.Add(C);

        Button Dividir = new Button();
        Dividir.Width = 115;
        Dividir.Height = 80;
        Dividir.BackColor = CinzaEscuro;
        Dividir.Text= "/";
        Dividir.Location = new Point(400, 650);
        Dividir.Click+=Dividir2;
        this.Controls.Add(Dividir);

        Button Vezes = new Button();
        Vezes.Width = 115;
        Vezes.Height = 80;
        Vezes.BackColor = CinzaEscuro;
        Vezes.Text= "X";
        Vezes.Location = new Point(400, 550);
        Vezes.Click+=Vezes2;
        this.Controls.Add(Vezes);

        Button Menos = new Button();
        Menos.Width = 115;
        Menos.Height = 80;
        Menos.BackColor = CinzaEscuro;
        Menos.Text= "-";
        Menos.Location = new Point(400, 450);
        Menos.Click+=Menos2;
        this.Controls.Add(Menos);

        Button Mais = new Button();
        Mais.Width = 115;
        Mais.Height = 80;
        Mais.BackColor = CinzaEscuro;
        Mais.Text= "+";
        Mais.Location = new Point(400, 350);
        Mais.Click+=Mais2;
        this.Controls.Add(Mais);
    }
    private void Button(object sender, EventArgs e)
    {
        Button clicado = (Button)sender;
        resultado.Text+=clicado.Text;
        
    }
    private void C2(object sender, EventArgs e)
    {
        resultado.Text = "";
        Numero_1 = 0;
        Numero_2=0;
        Mais_Boll = false;
        Menos_Bool = false;
        Vezes_Bool = false;
        Dividir_Bool = false;
    }
    private void Mais2(object sender, EventArgs e)
    {
        string Numero_1_text = resultado.Text;
        Numero_1 = double.Parse(Numero_1_text);
        Mais_Boll = true;
        resultado.Text = ""; 
    }
     private void Menos2(object sender, EventArgs e)
    {
        string Numero_1_text = resultado.Text;
        Numero_1 = double.Parse(Numero_1_text);
        Menos_Bool = true;
        resultado.Text = ""; 
    }
     private void Vezes2(object sender, EventArgs e)
    {
        string Numero_1_text = resultado.Text;
        Numero_1 = double.Parse(Numero_1_text);
        Vezes_Bool = true;
        resultado.Text = ""; 
    }
     private void Dividir2(object sender, EventArgs e)
    {
        string Numero_1_text = resultado.Text;
        Numero_1 = double.Parse(Numero_1_text);
        Dividir_Bool = true;
        resultado.Text = ""; 
    }

    private void Igual2(object sender, EventArgs e)
    {
        if (Mais_Boll== true)
        {
            string Numero_2_text = resultado.Text;
            Numero_2 = double.Parse(Numero_2_text);
            double Soma = Numero_1 + Numero_2;
            resultado.Text = Soma.ToString();
        } if (Menos_Bool == true)
        {
            string Numero_2_text = resultado.Text;
            Numero_2 = double.Parse(Numero_2_text);
            double Soma = Numero_1 - Numero_2;
            resultado.Text = Soma.ToString();
        }  if (Vezes_Bool== true)
        {
            string Numero_2_text = resultado.Text;
            Numero_2 = double.Parse(Numero_2_text);
            double Soma = Numero_1 * Numero_2;
            resultado.Text = Soma.ToString();
        }
          if (Dividir_Bool== true)
        {
            string Numero_2_text = resultado.Text;
            Numero_2 = double.Parse(Numero_2_text);
            double Soma = Numero_1 / Numero_2;
            resultado.Text = Soma.ToString();
        }
        Mais_Boll = false;
        Menos_Bool = false;
        Vezes_Bool = false;
        Dividir_Bool = false;
    }
}
