string userInput = "";
while(userInput != "4"){ 
    DisplayMenu();
    userInput = GetUserChoice(); 
    RouteEm(userInput);
}

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("1. Plain Pizza\n2. Cheese Pizza\n3. Pepperoni Pizza\n4. Exit");
}

static string GetUserChoice(){
    return Console.ReadLine();
}

static void RouteEm(string userInput){
    switch(userInput){
        case "1":
            PlainPizza();
            break;
        case "2":
            CheesePizza();
            break;
        case "3":
            PepperoniPizza();
            break;
        case "4":
            SayBye();
            break;
        default:
            BadInput();
            break;
    }
    Pause();
}


static void PlainPizza(){
    Random rnd = new Random();
    int number = rnd.Next(8,13);

    for(int i = number; i>=0; i--){
        for(int j = 0; j<=i; j++){
            System.Console.Write("*");
        }
    System.Console.WriteLine();
    }
}

static void CheesePizza() {
    Random rnd = new Random();
    int number = rnd.Next(8, 13);

    for (int i = number; i >= 0; i--){
        for (int j = 0; j <= i; j++){
            if(i == number){
                Console.Write("*");
            }
            else if (j == 0 || j == i){
                Console.Write("*");
            }
            else{
            Console.Write("#");
            }
        }
        Console.WriteLine();
    }
}

static void PepperoniPizza(){
    Random rnd = new Random();  
    int number = rnd.Next(8, 13);  
    for (int i = number; i >= 0; i--) {
        for (int j = 0; j <= i; j++) {
            if (i == number) {
                Console.Write("*");
            }
            else if (j == 0 || j == i) {
                Console.Write("*");
            }
            else {
                int pepperoniPlace = rnd.Next(0, 2);  
                if (pepperoniPlace == 0) {
                    Console.Write("#");  
                } else {
                    Console.Write("[]");  
                }
            }
        }
        Console.WriteLine();
    }
}

static void Pause(){
    System.Console.WriteLine("Press any key to continue..");
    Console.ReadKey();
}

static void SayBye(){
    System.Console.WriteLine("Goodbye!!");
}

static void BadInput(){
    Console.WriteLine("Invalid menu choice");
    Pause();
