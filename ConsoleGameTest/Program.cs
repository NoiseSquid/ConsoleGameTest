// See https://aka.ms/new-console-template for more information

using ConsoleGameTest.GameObjects;
using ConsoleGameTest.UserInteraction;





var ui = new ConsoleUI();

ui.ShowMessage("Testing...");


var dungeon = new Dungeon();
dungeon.AddPlayer();

dungeon.Player.Inventory.AddItem("sword");
dungeon.Player.Inventory.AddItems("apple", 6);



