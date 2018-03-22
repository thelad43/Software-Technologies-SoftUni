function solve(args) {
	let kvp = [];
	for (let i = 0; i < args.length - 1; i++) {
		let tokens = args[i].split(' ');
		let key = tokens[0];
		let pair = tokens[1];
		kvp[key] = pair;
	}

	let searchedKey = args[args.length - 1];
	if (kvp[searchedKey] != null) {
		console.log(kvp[searchedKey]);
	} else {
		console.log('None');
	}
}