function solve(args) {
	let object = {};
	for (let pair of args) {
		let tokens = pair.split("->");
		let key = tokens[0].trim();
		let value = tokens[1].trim();
		if (!isNaN(value)) {
			value = parseFloat(value);
		}
		object[key] = value;
	}
	
	let json = JSON.stringify(object);
	console.log(json);
}