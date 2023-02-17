
function CheckFormData(){

	if ($("#fio").val() != "")
	{
		$("#errorText").text("");
	}
	else
	{
		$("#errorText").text("Заполните поле имени!");
		return;
	}

	let pattern = /^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$/i;
	if(pattern.test($('#eml').val()))
	{
		$("#errorText").text("");
	}
	else
	{
		$("#errorText").text("Формат E-mail неверный!");
		return;
	}

	let pattern2 = /^\+\d{3}\(\d{2}\)\d{3}-\d{2}-\d{2}$/i;
	if(pattern2.test($('#phn').val()))
	{
		$("#errorText").text("");
	}
	else
	{
		$("#errorText").text("Формат номера неверный!");
		return;
	}

	if ($('#txt').val() != "")
	{
		$("#errorText").text("Готово. Форму можно отправлять.");
	}
	else
	{
		$("#errorText").text("Заполните текст для отправки!");
		return;
	}
}
