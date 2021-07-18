-- FUNCTION: CricketSelection.selectedteam(real, real, integer, integer, integer)

-- DROP FUNCTION "CricketSelection".selectedteam(real, real, integer, integer, integer);

CREATE OR REPLACE FUNCTION "CricketSelection".selectedteam(
	height real,
	bmi real,
	runs integer,
	wickets integer,
	stumpings integer)
    RETURNS TABLE("playerId" integer, "playerName" character varying, "playerCountry" character varying, "playerType" character varying, "playerHeight" real, "playerBmi" real, "playerRuns" integer, "playerWickets" integer, "playerStumpings" integer) 
    LANGUAGE 'sql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
(select * from "CricketSelection"."Players" where "playerType"= 'batsman' and 
"playerRuns" >runs and "playerBmi"<bmi and "playerHeight">height Limit 5)
union
(select * from "CricketSelection"."Players" where "playerType"= 'bowler' and "playerWickets" > wickets 
and "playerBmi"<bmi and "playerHeight">height Limit 5)
union
(select * from "CricketSelection"."Players" where "playerType"= 'keeper' and 
"playerStumpings" > stumpings and "playerBmi"<bmi and "playerHeight">height Limit 1)
$BODY$;

ALTER FUNCTION "CricketSelection".selectedteam(real, real, integer, integer, integer)
    OWNER TO postgres;
