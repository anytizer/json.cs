<?php
// http://localhost:80/tests.php
// http://localhost:80/angular/libraries/dto.php/cs/tests/api/members.php
require_once("class.member.inc.php");

$idv = array();
$idv[] = new member("90", "ninety", "90 90 90");
$idv[] = new member("91", "ninety one", "91 91 91");
$idv[] = new member("92", "ninety two", "92 92 92");

echo json_encode($idv);
