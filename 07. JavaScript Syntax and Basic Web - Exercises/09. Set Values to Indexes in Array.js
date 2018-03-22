function solve(args) {
	let n = +args[0];
	let arr = new Array(n).fill(0);
	for (let i = 1; i < args.length; i++) {
		let params = args[i].split('- ');
		let index = Number(params[0]);
		let value = Number(params[1]);
		arr[index] = value;
	}
	console.log(arr.join('\n'));
}