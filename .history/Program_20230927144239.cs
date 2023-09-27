// See https://aka.ms/new-console-template for more information

static void Menu () {
  Console.Clear();
  Console.WriteLine("Choose an option below:");
  Console.WriteLine("1 - Open file");
  Console.WriteLine("2 - New file");
  Console.WriteLine("0 - Exit");

  var option = short.Parse(Console.ReadLine());
}

static void Open() {}
