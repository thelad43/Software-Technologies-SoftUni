function solve([input]) {
	let n = Number(input);
	for (let i = 1; i <= n; i++) {
		if (isSymmetric(i)) {
			console.log(i);
		}
	}

	function isSymmetric(number) {
		number = number.toString();

		for (let i = 0; i < number.length / 2; i++) {
			if (number[i] != number[number.length - 1 - i]) {
				return false;
			}
		}
		return true;
	}
}