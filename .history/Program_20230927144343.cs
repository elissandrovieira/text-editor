// See https://aka.ms/new-console-template for more information

static void Menu () {
  Console.Clear();
  Console.WriteLine("Choose an option below:");
  Console.WriteLine("1 - Open file");
  Console.WriteLine("2 - New file");
  Console.WriteLine("0 - Exit");

  var option = short.Parse(Console.ReadLine());

  switch (option) {
    case 0: Environment.Exit(0); break;
    case 1: Open
  }
}

static void Open() {}

static void Edit() {}