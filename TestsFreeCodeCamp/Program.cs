/*This code reverses a message, counts the number of times a particular char appears
Then prints the result on the console*/

using System.Runtime.InteropServices;

string OriginalMessage = "The quick brown fox jumps over the lazy brown dog!";

//convert the OrignalMessage into an chars

char[] message = OriginalMessage.ToCharArray();

 //reverser the chars

Array.Reverse(message);

/*Setup the count.
step 1: 1 Intilize the count
step 2 : create a foreach loop to loop through the chars
step 3 : add to the original count */

int letterCount = 0;

foreach(char letter in message){

    if(letter == 'o'){
       letterCount++;
    }   
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' apprears {letterCount} Times");






