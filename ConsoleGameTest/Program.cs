// See https://aka.ms/new-console-template for more information

using ConsoleGameTest.UserInteraction;





var ui = new ConsoleUI();

ui.ShowMessage("Testing...");

var options = new List<Option>();
options.Add(new Option("First"));
options.Add(new Option("Second"));
options.Add(new Option("Third"));

var selection = ui.ForceOptionSelect(options);
ui.ShowMessage(string.Format("You selected option {0} - {1}", selection + 1, options[selection].Display));

ui.ShowMessage("Finished");