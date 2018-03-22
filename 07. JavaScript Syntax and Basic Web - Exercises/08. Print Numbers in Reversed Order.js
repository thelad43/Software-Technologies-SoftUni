function solve(args) {
	let arr = [];
	for (let i = 0; i < args.length; i++) {
		arr[i] = Number(args[i]);
	}

	arr = arr.reverse();
	arr.forEach(element => {
		console.log(element);
	});
}