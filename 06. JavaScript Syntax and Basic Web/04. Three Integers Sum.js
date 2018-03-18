function solve([input]) {
	let nums = input.split(' ');
	let firstNum = Number(nums[0]);
	let secondNum = Number(nums[1]);
	let thirdNum = Number(nums[2]);

	if (firstNum + secondNum === thirdNum) {
		console.log(`${Math.min(firstNum, secondNum)} + ${Math.max(firstNum, secondNum)} = ${thirdNum}`);
	} else if (firstNum + thirdNum === secondNum) {
		console.log(`${Math.min(firstNum, thirdNum)} + ${Math.max(firstNum, thirdNum)} = ${secondNum}`);
	} else if (secondNum + thirdNum === firstNum) {
		console.log(`${Math.min(secondNum, thirdNum)} + ${Math.max(secondNum, thirdNum)} = ${firstNum}`);
	} else {
		console.log('No');
	}
}