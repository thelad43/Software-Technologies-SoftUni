function sumNumbers() {
	let firstNumber = Number(document.getElementById('num1').value);
	let secondNumber = Number(document.getElementById('num2').value);
	let result = firstNumber + secondNumber;
	document.getElementById('result').innerHTML = result;
}