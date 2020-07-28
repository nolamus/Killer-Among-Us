-> Scene1
=== Scene1 === 
DUMMY TEXT SCENE 1.
+ [Then, continue.] -> intro


=== intro ===
Boy: Oh, hello.
Concierge: What are you doing here?
+ [Hmph. I should be asking you that question.] -> agg
+ [Sorry, I just saw what was happening outside...] -> soft


=== agg ===
Concierge: Watch yourself. You shouldn't speak to me like that.
+ [I don't care. Where's mom?] -> knot
+ [Have you seen my mom?] -> knot
=== soft ===
Concierge: It's not safe here.
+ [I don't care. Where's mom?] -> knot
+ [Have you seen my mom?] -> knot


=== knot ===
Concierge: You know what happened right? There's been a fire in the hotel that has burned a part of it down.
+ [Well yeah, that's obvious. How did the fire happen?] -> agg1
+ [But where is my mom then?] -> soft1


=== agg1 ===
Concierge: I'm not sure. The police are still looking into who or what caused the fire. But your mom...she died in the fire along with a lot of the hotel guests.
+ [If my mom is dead...I don't want to sit around and wait for the police to find out who did this.] -> knot1
+ [Why would someone do this?] -> knot1
=== soft1 ===
Concierge: I heard that a lot of the hotel guests have died in the fire. And your mom...has died as well. The police are still looking into who or what caused the fire.
+ [I want to know who did this to her.] -> knot1
+ [Why would someone do this?] -> knot1


=== knot1 ===
Concierge: I don't know who did this. But I don't know if it is safe for you to be hanging around here. People have been reporting strange things happening around the hotel...like ghost sightings.
+ [Is that supposed to scare me?] -> agg2
+ [I have to know the truth.] -> soft2


=== agg2 ===
Concierge: You're stronger than you look.
+ [...] -> ending
=== soft2 ===
Concierge: If you want to find out who did this...you're going to have to talk to more of the hotel staff.
+ [Ok, fine.] -> ending


=== ending
Concierge: Hmmm. Well I guess it can't be helped. I would start by talking to the Bellhop. He has the ability to see who goes in and out of the hotel more than me. Oh! And I would ask about the necklace incident...
-> END