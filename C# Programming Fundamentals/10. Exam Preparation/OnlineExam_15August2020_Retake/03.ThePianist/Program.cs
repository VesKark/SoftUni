using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        // input music pieces:
        int number = int.Parse(Console.ReadLine());
        Dictionary<string, MusicCollection> allPieces = new Dictionary<string, MusicCollection>();

        for (int i = 0; i < number; i++)
        {
            string[] piece = Console.ReadLine().Split('|');
            string pieceName = piece[0];
            string composer = piece[1];
            string key = piece[2];

            MusicCollection currPiece = new MusicCollection(composer, key);
            allPieces[pieceName] = currPiece;
        }

        // make changes to Music Collection:
        string inputCommand = string.Empty;

        while ((inputCommand = Console.ReadLine()) != "Stop")
        {
            string[] command = inputCommand.Split('|');
            string action = command[0];
            string piece = command[1];

            if (action == "Add")
            {
                if (allPieces.ContainsKey(piece))
                {
                    Console.WriteLine("{0} is already in the collection!", piece);
                }
                else
                {
                    string composer = command[2];
                    string key = command[3];

                    MusicCollection currPiece = new MusicCollection(composer, key);
                    allPieces[piece] = currPiece;

                    Console.WriteLine("{0} by {1} in {2} added to the collection!", piece, composer, key);
                }
            }
            else if (action == "Remove")
            {
                if (allPieces.ContainsKey(piece))
                {
                    allPieces.Remove(piece);
                    Console.WriteLine("Successfully removed {0}!", piece);
                }
                else
                {
                    Console.WriteLine("Invalid operation! {0} does not exist in the collection.", piece);
                }
            }
            else if (action == "ChangeKey")
            {
                if (allPieces.ContainsKey(piece))
                {
                    string key = command[2];

                    allPieces[piece].Key = key;
                    Console.WriteLine("Changed the key of {0} to {1}!", piece, key);
                }
                else
                {
                    Console.WriteLine("Invalid operation! {0} does not exist in the collection.", piece);
                }
            }
        }

        // print Music Collection:
        foreach (var musicPiece in allPieces)
        {
            Console.WriteLine("{0} -> Composer: {1}, Key: {2}", musicPiece.Key, musicPiece.Value.ComposerName, musicPiece.Value.Key);
        }
    }
}

class MusicCollection
{
    public MusicCollection(string composerName, string key)
    {
        ComposerName = composerName;
        Key = key;
    }

    public string ComposerName { get; set; }
    public string Key { get; set; }
}