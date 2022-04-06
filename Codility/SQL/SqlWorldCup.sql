/**
* Level: medium
* https://app.codility.com/programmers/trainings/6/sql_world_cup/
*/
SELECT 
    t2.team_id,
    t2.team_name,
    COALESCE(SUM(t1.point), 0) AS num_points
FROM
    (SELECT 
        CASE
                WHEN host_goals > guest_goals THEN 3
                WHEN host_goals = guest_goals THEN 1
                ELSE 0
            END AS point,
            host_team AS team_id
    FROM
        matches UNION ALL SELECT 
        CASE
                WHEN host_goals < guest_goals THEN 3
                WHEN host_goals = guest_goals THEN 1
                ELSE 0
            END AS point,
            guest_team AS team_id
    FROM
        matches) AS t1
        RIGHT JOIN
    teams AS t2 ON t1.team_id = t2.team_id
GROUP BY t2.team_id, t2.team_name
ORDER BY num_points DESC , t2.team_id ASC