<?php
class member
{
	public $id;
	public $name;
	public $value;
	
	public function __construct(string $id, string $name, string $value)
	{
		$this->id = $id;
		$this->name = $name;
		$this->value = $value;
	}
}