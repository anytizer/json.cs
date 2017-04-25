<?php
$qotds = [
	"A quick brown fox jumps over the lazy dog.",
	"There are so many reasons to be happy.",
	"Do not jump on the bed.",
];

$index = mt_rand(0, count($qotds)-1);
echo $qotds[$index];
