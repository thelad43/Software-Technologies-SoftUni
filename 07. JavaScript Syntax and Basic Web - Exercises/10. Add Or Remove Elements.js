function solve(args) {
	let arr = [];
	for (let i = 0; i < args.length; i++) {
		let currentLine = args[i];
		let tokens = currentLine.split(' ');
		if (tokens[0].startsWith("add")) {
			arr.push(tokens[1]);
		} else {
			arr.splice(tokens[1], 1);
		}
	}

	for (let element of arr) {
		console.log(element);
	}
}