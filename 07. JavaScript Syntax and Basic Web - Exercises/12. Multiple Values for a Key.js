function solve(args) {
	let object = {};
	for (let i = 0; i < args.length - 1; i++) {
		let tokens = args[i].split(' ');
		let key = tokens[0];
		let value = tokens[1];

		if (!object.hasOwnProperty(key)) {
			object[key] = new Array();
		}

		object[key].push(value);
	}

	let key = args[args.length - 1];

	if (object.hasOwnProperty(key)) {
		for (let value of object[key]) {
			console.log(value);
		}
	} else {
		console.log("None");
	}
}