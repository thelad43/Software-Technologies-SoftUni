function solve(args) {
	let countOfNegatives = 0;
	for (let i = 0; i < 3; i++) {
		if (Number(args[i]) < 0) {
			countOfNegatives++;
		}
	}
	
	if (countOfNegatives % 2 == 0) {
		console.log('Positive');
	} else {
		console.log('Negative');
	}
}