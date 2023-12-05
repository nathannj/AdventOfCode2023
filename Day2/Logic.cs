public static class Logic {
    public static int PartOne(string line) {
        var colonSplit = line.Split(':');
        var gameIdString = colonSplit[0];        
        var gameId = int.Parse(gameIdString.Replace("Game ", ""));

        var rounds = colonSplit[1].Split(';');
        var possible = true;

        foreach (var round in rounds) {
            var numberOfEachColour = round.Split(',');

            foreach(var numberOfColour in numberOfEachColour) {
                var numberAndColour = numberOfColour.Split(' ');

                switch(numberAndColour[2]) {
                    case "blue":
                        if (int.Parse(numberAndColour[1]) > 14) {
                            possible = false;
                        }
                    break;
                    case "green":
                        if (int.Parse(numberAndColour[1]) > 13) {
                            possible = false;
                        }
                    break;
                    case "red":
                        if (int.Parse(numberAndColour[1]) > 12) {
                            possible = false;
                        }
                    break;
                }
            }
        }

        return possible ? gameId : 0;
    }

     public static int PartTwo(string line) {
        var colonSplit = line.Split(':');
        var gameIdString = colonSplit[0];        
        var gameId = int.Parse(gameIdString.Replace("Game ", ""));

        var rounds = colonSplit[1].Split(';');
        var blue = 0;
        var red = 0;
        var green = 0;

        foreach (var round in rounds) {
            var numberOfEachColour = round.Split(',');

            foreach(var numberOfColour in numberOfEachColour) {
                var numberAndColour = numberOfColour.Split(' ');

                switch(numberAndColour[2]) {
                    case "blue":
                        if (int.Parse(numberAndColour[1]) > blue) {
                            blue = int.Parse(numberAndColour[1]);
                        }
                    break;
                    case "green":
                        if (int.Parse(numberAndColour[1]) > green) {
                            green = int.Parse(numberAndColour[1]);
                        }
                    break;
                    case "red":
                        if (int.Parse(numberAndColour[1]) > red) {
                            red = int.Parse(numberAndColour[1]);
                        }
                    break;
                }
            }
        }

        return red*green*blue;
    }
}