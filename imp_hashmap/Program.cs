namespace imp_hashmap;

class Booking
{
    // todo: nao deixar sair na hora que acabar a opcao / nao deixar o programa encerrar
    // todo: colocar trativa para nao deixar selecionar uma opcao sem nao ter criado nenhuma

    public static void Main(string[] args)
    {
        string name_hotel = "N/a", number_hotel = "N/a", date_check_in = DateTime.Now.ToString(), date_check_out = DateTime.Now.ToString();
        int option_selected = 0;
        Dictionary<int, string> booking = new Dictionary<int, string>();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("-------------------------------------------------\nBem-vindo ao melhor programa de hotel do mundo ❤\n-------------------------------------------------\n");
        Console.ForegroundColor = ConsoleColor.White;

        selectOption(booking, name_hotel, number_hotel, date_check_in, date_check_out);
    }

    public static void selectOption(Dictionary<int, string> booking, string name_hotel, string number_hotel, string date_check_in, string date_check_out)
    {
        int option_selected = 0;
        Console.WriteLine("Selecione uma opção abaixo: \n1. Criar reserva\n2. Procurar reserva\n3. Remover reserva\n4. Sair\n");
        option_selected = Convert.ToInt32(Console.ReadLine());


        switch (option_selected)
        {
            case 1:
                Add(booking, name_hotel, number_hotel, date_check_in, date_check_out);
                break;
            case 2:
                List(booking);
                break;
            case 3:
                Remove(booking);
                break;
            case 4:
                Environment.Exit(0);
                break;
        }
    }

    public static void Add(Dictionary<int, string> booking, string name_hotel, string number_hotel, string date_check_in, string date_check_out)
    {
        Console.WriteLine("Digite o nome do hotel: ");
        name_hotel = Console.ReadLine();
        Console.WriteLine("Digite o número do quarto: ");
        number_hotel = Console.ReadLine();
        Console.WriteLine("Digite a data de Check In: ");
        date_check_in = Console.ReadLine();
        Console.WriteLine("Digite a data de Check Out: ");
        date_check_out = Console.ReadLine();

        booking.Add(booking.Count,"Nome hotel: " + name_hotel + "Número quarto: " + number_hotel + " Data check in: " + date_check_in + " Data check out: " + date_check_out);

        Console.WriteLine("Reserva efetuada com sucesso!");

        foreach (KeyValuePair<int, string> kvp in booking)
            Console.WriteLine("Código da reserva: {0}, Value: {1}", kvp.Key, kvp.Value);

        want_exit();

    }

    public static void List(Dictionary<int, string> booking)
    {

        int nmb_booking = 0;

        Console.WriteLine("Digite o número da reserva que deseja procurar: ");
        nmb_booking = Convert.ToInt32(Console.ReadLine());

        foreach (KeyValuePair<int, string> kvp in booking)
        {
            if (kvp.Key == nmb_booking)
            {
                Console.WriteLine("Código da reserva: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
        }

        /*if (booking.TryGetValue(nmb_booking, out value))
        {
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("Não foi possível achar a chave especificada.");
        }*/

            want_exit();
    }

    public static void Remove(Dictionary<int, string> booking)
    {
        int nmb_booking = 0;
        Console.WriteLine("Digite o número da reserva que deseja remover: ");
        nmb_booking = Convert.ToInt32(Console.ReadLine());

        booking.Remove(nmb_booking);

        Console.WriteLine("Reserva removida com sucesso!");

        want_exit();
    }

    public static void want_exit()
    {
        Console.WriteLine("Deseja sair do programa? (s/n)");
        string exit = Console.ReadLine();

        if (exit == "s")
        {
            Environment.Exit(0);
        }
        else
        {
            Main(null);
        }
    }

}
