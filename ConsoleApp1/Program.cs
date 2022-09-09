// See https://aka.ms/new-console-template for more information
using Kordamine_Harjutus;

Tootaja tootaja = new Tootaja("Mihkail", 1981, Tootaja.sugu.isane, "TTHK", "Programmer", 1600);
Opilane opilane = new Opilane("Artjom", 2004, Opilane.sugu.isane, "TTHK", "3.kursus", "Tarkvaraarendaja");
Kutsekooliopilane kutseop = new Kutsekooliopilane("Mark", 2000, Opilane.sugu.emane, "TTHK", "Juuksur", 3);
tootaja.print_Info();
opilane.print_Info();
kutseop.print_Info();

Tootaja worker = new Tootaja(tootaja);
Opilane student = new Opilane(opilane);
Kutsekooliopilane PrStudent = new Kutsekooliopilane(kutseop);
changeName();
studentChanges();
kutseOpilaneChanges();
tootajaChanges();

void changeName()
{ 
    Console.Write("\nKas sa tahad muutuda nimi? (jah/ei): ");
    string answer = Console.ReadLine();
    if (answer == "jah")
    {
        Console.Write("kes see on (1(Opilane), 2(Töötaja), 3(Kutsekooliopilane)): ");
        int answerWho = Convert.ToInt32(Console.ReadLine());
        Console.Write("kirjuta uus nimi ");
        string answerName = Console.ReadLine();
        if (answerWho == 1)
        {   
            student.muudaNimi(answerName);
            student.print_Info();
        }
        else if (answerWho == 2)
        {
            worker.muudaNimi(answerName);
            worker.print_Info();
        }
        else if(answerWho == 3)
        {
            PrStudent.muudaNimi(answerName);
            PrStudent.print_Info();
        }
    }
    else {
        Console.WriteLine("ilma muudatusteta");
    }
}

void studentChanges()
{
    Console.Write("\nKas sa tahad muutuda kool? (jah/ei): ");
    string answerS = Console.ReadLine();
    if (answerS == "jah")
    {
        Console.Write("Kirjuta kool: ");
        string newSchool = Console.ReadLine();
        student.muudaKooli(newSchool);
        student.print_Info();
    }
    else {
        Console.WriteLine("ilma muudatusteta");
    }

    Console.Write("\nKas sa tahad muutuda sugu? (jah/ei): ");
    answerS = Console.ReadLine();
    if (answerS == "Jah")
    {
        var isane = Isik.sugu.isane;
        var emane = Isik.sugu.emane;
        List<Isik.sugu> variables = new List<Isik.sugu>() { isane, emane };
        Console.Write("Kirjuta sugu (isane - 1/emane - 2): ");
        int genderAn = Convert.ToInt32(Console.ReadLine());
        try
        {
            student.muudaSugu(variables[genderAn - 1]);
            student.print_Info();
        }
        catch (Exception)
        {
            
        }
    }
    else {
        Console.WriteLine("ilma muudatusteta");
    }
}

void kutseOpilaneChanges()
{
    Console.Write("\nKas sa tahad muutuda oppeasutus? (jah/ei): ");
    string answerP = Console.ReadLine();
    if (answerP == "jah")
    {
        Console.Write("Kirjuta uus oppeasutus  ");
        string ansPlace = Console.ReadLine();
        PrStudent.muudaPlace(ansPlace);
    }
    else {
        Console.WriteLine("ilma muudatusteta");
    }

    Console.Write("as sa tahad muutuda amet? (jah/ei): ");
    string answerPr = Console.ReadLine();
    if (answerPr == "jah")
    {
        Console.Write("Kirjuta uus amet ");
        string ansPlace = Console.ReadLine();
        PrStudent.muudaProf(ansPlace);
    }
    else
    {
        Console.WriteLine("ilma muudatusteta");
    }

    Console.Write("as sa tahad muutuda kursus? (jah/ei): ");
    string answerK = Console.ReadLine();
    if (answerK == "jah")
    {
        Console.Write("kirjuta uus kursus (number: 1 - 6): ");
        int ansKurs = Convert.ToInt32(Console.ReadLine());
        PrStudent.muudaKurs(ansKurs);
    }
    else
    {
        Console.WriteLine("ilma muudatusteta");
    }
    PrStudent.print_Info();
}
void tootajaChanges()
{
    
    Console.Write("as sa tahad muutuda amet? (jah/ei): ");
    string answerRp = Console.ReadLine();
    if (answerRp == "jah")
    {
        Console.Write("Kirjuta uus amet ");
        string uusAmet = Console.ReadLine();
        tootaja.muudaAmet(uusAmet);
    }
    else
    {
        Console.WriteLine("ilma muudatusteta");
    }

    Console.Write("as sa tahad muutuda asutus? (jah/ei): ");
    string answerPr = Console.ReadLine();
    if (answerPr == "jah")
    {
        Console.Write("kirjuta uus asutus  ");
        string uusAsutus = Console.ReadLine();
        tootaja.muudaAsutus(uusAsutus);
    }
    else
    {
        Console.WriteLine("ilma muudatusteta");
    }
    tootaja.print_Info();
}
