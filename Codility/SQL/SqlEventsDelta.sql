/**
* Level: easy
*/
SELECT 
    event_type,
    ((SELECT 
            value
        FROM
            events e
        WHERE
            e.event_type = ev.event_type
        ORDER BY time DESC
        LIMIT 1) - (SELECT 
            value
        FROM
            events e
        WHERE
            e.event_type = ev.event_type
        ORDER BY time DESC
        LIMIT 1 OFFSET 1)) AS value
FROM
    events ev
GROUP BY event_type
HAVING COUNT(event_type) > 1 order by event_type;