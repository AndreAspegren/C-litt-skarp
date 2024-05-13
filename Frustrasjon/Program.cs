using Microsoft.VisualBasic;

namespace yepp {

internal class frustrasjon {

static bool santUsant = true;

static bool isTrue() {
    return santUsant;
}

static int[] arr = new int[10];

enum ukedager {
    mandag,
    tirsdag,
    onsdag,
    torsdag,
    fredag,
    lørdag,
    søndag,
}

static int n(){
    return 5;
}

static void Main(string[] args){
var values = new int[10];
values = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    bool ja = isTrue();
    int num = n();
    var line = Console.ReadLine();
    Console.WriteLine(@$"{ja} 
    {ukedager.fredag} 
    {line}");
}


}
}