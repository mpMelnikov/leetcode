// var result = new Solution1402().MaxSatisfaction(new int[] { -1, -8, 0, 5, -9  });

// var result = new Solution2300().SuccessfulPairs(
//         spells: new int[] { 5, 1, 3 },
//         potions: new int[] { 1, 2, 3, 4, 5 },
//         success: 7);

// var result = new Solution880().NumRescueBoats(
// //        people: new int[] { 1, 2 },
//         people: new int[] { 3, 2, 2, 1 },
//         limit: 3);

// var result = new Solution2405().PartitionString("abacaba");
// var result = new Solution2405().PartitionString("ssssss");

// var result = new Solution2439().MinimizeArrayValue(new int[] { 3, 7, 1, 6 });
// var result = new Solution2439().MinimizeArrayValue(new int[] { 13,13,20,0,8,9,9 });

// var grid = new int[,] { {1,1,1,1,1,1,1,0},{1,0,0,0,0,1,1,0},{1,0,1,0,1,1,1,0},{1,0,0,0,0,1,0,1},{1,1,1,1,1,1,1,0}};
// var grid = new int[,] {{0,0,1,0,0},{0,1,0,1,0},{0,1,1,1,0}};
// var grid = new int[,] {{0,0,1,1,0,1,0,0,1,0},{1,1,0,1,1,0,1,1,1,0},{1,0,1,1,1,0,0,1,1,0},{0,1,1,0,0,0,0,1,0,1},{0,0,0,0,0,0,1,1,1,0},{0,1,0,1,0,1,0,1,1,1},{1,0,1,0,1,1,0,0,0,1},{1,1,1,1,1,1,0,0,0,0},{1,1,1,0,0,1,0,1,0,1},{1,1,1,0,1,1,0,1,1,0}};
// var result = new Solution1254().ClosedIsland(grid.ToJagged());

// var grid = new int[,] {{0,0,0,0},{1,0,1,0},{0,1,1,0},{0,0,0,0}};
// int result = new Solution1020().NumEnclaves(grid.ToJagged());

// var adjArray = new int[,] {{2,4}, {1,3}, {2,4}, {1,3}}.ToJagged();
// var node = GraphBuilder.Create(adjArray);
// var result = new Solution133().CloneGraph(node);
var result = new Solution2390().RemoveStars("leet**cod*e");
Printer.Print(result);
