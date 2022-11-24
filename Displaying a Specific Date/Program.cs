/* TASK:
 *  When working with dates, you do not have to always start from today’s date. You can
    choose some specific date.
 */
DateTime newFormat = new DateTime(1992, 9, 29);

// output 
Console.WriteLine (" I was born on " + newFormat.ToLongDateString());

// Waiting for Enter
Console.ReadLine();