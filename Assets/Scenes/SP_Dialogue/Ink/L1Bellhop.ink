Boy: Are you the bellhop?
-> intro
=== intro ===
Bellhop: Yes, may I help you?
+ [Do you know anything about the necklace incident?] -> agg
+ [Sorry to bother you. The concierge told me to talk to you.] -> soft


=== agg ===
Bellhop: Who wants to know?
+ [I do. My mom was the manager of the hotel.] -> begin_story
+ [My mom was the manager of the hotel. I'm trying to found out more about what happened.] -> begin_story
=== soft ===
Bellhop: Oh I see. What did you want to talk about?
+ [Well...the concierge told me to ask you about the necklace incident.] -> temp_soft


=== temp_soft ===
Bellhop: Why do you want to know about it?
+ [My mom was the manager of the hotel. I'm trying to found out more about what happened.] -> begin_story


=== begin_story ===
Bellhop: I guess you have a right to know. Ok, fine. I'll tell you about it.
+ [...] -> story


=== story ===
Bellhop: One day, one of our VIP customers went to the concierge complaining about a necklace that was stolen from her room. It was a pretty big ordeal for the hotel as it could have ruined our reputation.
+ [Were you the one that stole the necklace or something?] -> agg1
+ [But how does this involve you?] -> soft1


=== agg1 ===
Bellhop: No...it wasn't me! I think it was your mom all along!
+ [What do you mean?] -> story1
=== soft1 ===
Bellhop: Your mom pressured me to keep quiet about the incident...
+ [What do you mean?] -> story1


=== story1 ===
Bellhop: I don't want to talk badly about anyone, but your mom...wasn't the kindest lady. She knew that I don't have a lot of money and that I really need this job.
+ [...] -> story2


=== story2 ===
Bellhop: That day, I had seen her go into the VIP room. So I confronted her about it. But she threatened me with my job and made me keep quiet.
+ [...] -> ending


=== ending
Bellhop: But that's all I know! I promise! I would talk to the maid. She was the one who was actually accused of stealing the necklace.
-> END