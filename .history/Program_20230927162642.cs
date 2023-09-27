// See https://aka.ms/new-console-template for more information

Menu();

static void Menu () {
  Console.Clear();
  Console.WriteLine("Choose an option below:");
  Console.WriteLine("1 - Open file");
  Console.WriteLine("2 - New file");
  Console.WriteLine("0 - Exit");
  Console.WriteLine("-----------------------------------------");

  var option = short.Parse(Console.ReadLine());

  switch (option) {
    case 0: Environment.Exit(0); break;
    case 1: Open(); break;
    case 2: Edit(); break;
    default: Menu(); break;
  }
}

static void Open() {
  
}

static void Edit() {
  Console.Clear();
  Console.WriteLine("Type your text here:");
  Console.WriteLine("Press ESC to exit");
  Console.WriteLine("-----------------------------------------");
  string text =  "";

  do {
    text += Console.ReadLine();
    text += Environment.NewLine;
  } 
  while (Console.ReadKey().Key != ConsoleKey.Escape);

  Save(text);
}

static void Save (string text) {
  Console.Clear();
  Console.WriteLine("Where do you want to save the file?");
  var path = Console.ReadLine();

  using(var file = new StreamWriter(path)){
    file.Write(text);
  }

  Console.WriteLine($"File saved successfully at {path}");
  Console.ReadLine();
  Menu();
}