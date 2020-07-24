-> Scene1
=== Scene1 === 
DUMMY TEXT SCENE 1.
+ [Then, continue.] -> intro


=== intro ===
Boy: Are you the bellhop?
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
Bellhop: One day, one of our VIP customers went to your mom complaining about a necklace that was stolen from her room. 
+ [...] ->Scene2


=== Scene2 ===
DUMMY TEXT SCENE 2.
+ [Then, continue.] -> story1


=== story1 ===
It was a pretty big deal for the hotel as it could have ruined our reputation.
+ [Were you the one that stole the necklace or something?] -> agg1
+ [But how does this involve you?] -> soft1


=== agg1 ===
Bellhop: No...it wasn't me! I think it was your mom all along!
+ [What do you mean?] -> story2
=== soft1 ===
Bellhop: Your mom pressured me to keep quiet about the incident...
+ [What do you mean?] -> story2


=== story2 ===
Bellhop: I don't want to talk badly about anyone, but your mom...wasn't the kindest lady. She knew that I didn't have a lot of money and that I really needed my job.
+ [...] -> story3


=== story3 ===
Bellhop: Earlier that day, I had seen her go into the VIP room. So I confronted her about it. But she threatened me with my job and made me keep quiet.
+ [...] -> Scene3


=== Scene3 ===
DUMMY TEXT SCENE 3.
+ [Then, continue.] -> story4


=== story4 ===
Bellhop: I confronted her about it, but she threatened me with my job and made me keep quiet.
+ [...] -> Scene4


=== Scene4 ===
DUMMY TEXT SCENE 4.
+ [Then, continue.] -> ending


=== ending
Bellhop: But that's all I know! I promise! I would talk to the maid. I think she was the one who was actually accused of stealing the necklace.
-> END