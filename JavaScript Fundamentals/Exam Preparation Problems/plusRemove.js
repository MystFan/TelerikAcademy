var example1 = [
'ab**l5',
'bBb*555',
'absh*5',
'ttHHH',
'ttth',
];
var example2 = [
'888**t*',
'8888ttt',
'888ttt<<',
'*8*0t>>hi'
];
var example3 = [
'@s@a@p@una',
'p@@@@@@@@dna',
'@6@t@*@*ego',
'vdig*****ne6',
'li??^*^*'
];

function  solve(params) {
	var matrix, index, j, i, p, lines, result, line, longestLine, diff, character, position, positions;

	function printResult(strLines) {
		for (var index = 0; index < strLines.length; index++) {
			console.log(strLines[index]);
		}
	}
	
	lines = new Array(0).concat(params);
	lines.sort(function (a, b) {
		return a.length - b.length;
	});
	longestLine = lines[lines.length - 1].length;
	
	if(params.length < 3 || lines[0].length < 3){
		printResult(params);
		return;
	}
	matrix = [];
	diff = 0;
	for (index = 0; index < params.length; index++) {
	    line = params[index].split('');
		if(line.length < longestLine){
			diff = longestLine - line.length;
		}
		for (i = 0; i < diff; i++) {
			line.push('');
		}
		matrix.push(line);
		diff = 0;
	}
	positions = [];
	for (i = 0; i < matrix.length - 2; i++) {
		for (j = 1; j < matrix[i].length - 1; j++) {
			character = matrix[i][j];
			if(character.length === 1){
				if(character.toLowerCase() === matrix[i + 1][j].toLowerCase() &&
				character.toLowerCase() === matrix[i + 2][j].toLowerCase() &&
				character.toLowerCase() === matrix[i + 1][j - 1].toLowerCase() &&
				character.toLowerCase() === matrix[i + 1][j + 1].toLowerCase() ){
					position = {};
					position.row = i;
					position.col = j;
					positions.push(position);
				}
			}
		}
	}
	for ( i = 0;  i < matrix.length; i++) {
		for (j = 0; j < matrix[i].length; j++) {
			for (p = 0; p < positions.length; p++) {
				if(positions[p].row === i && positions[p].col === j){
					matrix[i + 1][j] = '';
					matrix[i + 2][j] ='';
					matrix[i + 1][j - 1] = '';
					matrix[i + 1][j + 1] = '';
					matrix[i][j] = '';
				}
			}
		}
	}
	result = [];
	for (index = 0; index < matrix.length; index++) {
		result.push(matrix[index].join(''));
	}
	printResult(result);
}
solve(example1);
solve(example2);
solve(example3);