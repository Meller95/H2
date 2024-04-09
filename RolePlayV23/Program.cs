
using RolePlayV23;

CharacterGroup redTeam = new CharacterGroup("Team Red");
redTeam.AddCharacter(new Character("Angor", 100, 15, 25));
redTeam.AddCharacter(new Character("Zurin", 85, 18, 30));
redTeam.AddCharacter(new Damager("Morgar", 110, 12, 20));
redTeam.AddCharacter(new Defender("Thurin", 150, 10, 15));

CharacterGroup greenTeam = new CharacterGroup("Team Green");
greenTeam.AddCharacter(new Character("Baldur", 120, 12, 18));
greenTeam.AddCharacter(new Character("Eliza", 80, 20, 35));
greenTeam.AddCharacter(new Damager("Gorin", 90, 15, 25));
greenTeam.AddCharacter(new Defender("Skagen", 140, 10, 15));
BattleHandler.DoBattle(redTeam, greenTeam);
