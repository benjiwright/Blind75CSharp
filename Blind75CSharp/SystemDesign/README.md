# System Design Interview

DDDish approach

 1. core subdomain - money maker
 2. support subdomain - aux
 3. generic subdomain - solved problems: Auth & Identity

## Functional Requirements

1. break into services that will be required
2. what data are we storing; reads/writes

## Non-functional Requirements

1. distributed system with event driven arch
   1. loose coupling
   2. scales
   3. HA
2. security
   1. at rest and in transit
   2. are we storing sensitive data? GDPR (EU)
3. Highly available: SLA (service level agreement), P95, P99 allowance

### Clarify

1. is this for browser, mobile, VR? (do not constrain yourself)

### Capacities Estimates (maybe skip)

system is distributed and will be (1) scalable (2) available

1. Traffic (QPS)
2. Storage
   1. Read vs. Write heavy
   2. lifecycle
   3. consistency model
      1. strong (strict)
         1. read might not be available
         2. higher latency
         3. not supported globally
      2. eventual
3. Bandwidth (kb/s)
   1. S3 w/ CloudFront as CDN (edge locations)
4. Memory

## Layer 1 - components (high level design)

1. what are components
2. components inputs/outputs
3. what components communicate with others

## Layer 2 - deeper dive on components (DDD: tactical design)

Goal: how we will be able to deliver on the requirements

Event Storming

1. Big Picture
2. Process Modeling

   | Actor => | Command =>    | System =>     | Domain Event =>      | Opportunity / Hot Spot |
   | -------- | ------------- | ------------- | -------------------- | ---------------------- |
   | Host     | Create Dinner | Dinner System | Dinner Created Event | Confirm Number         |

3. Software Design by Aggregate E.g.: Dinner
   1. define entities and their relationships? Airbnb: reservation entity has a guest entity and host entity 

API GW

* throttling
* auth (token verification)
* routing
* whitelist IP/region/etc
* 10k RPS
* 30s timeout on request =(

ALB

* more intelligent load distribution
* more affordable at scale after ~0.5M request/month

| Feature                     | API Gateway                                                   | ALB                                                        |
| --------------------------- | ------------------------------------------------------------- | ---------------------------------------------------------- |
| Protocols supported         | HTTP/2 (HTTP API, REST API), WebSockets                       | HTTP/2, WebSockets, gRPC                                   |
| HTTPS                       | Out-of-the-box support                                        | SSL certificate configuration required for SSL termination |
| A/B testing support         | Support through defining separate routes                      | Load balancing based on % of traffic                       |
| Load balancing strategy     | Round robin                                                   | Round robin or least connections strategies                |
| AWS service integration     | Amazon EC2, Amazon ECS, AWS Lambda, Amazon S3, Amazon Kinesis | Amazon EC2, Amazon ECS, AWS Lambda                         |
| Sticky session support      | No out-of-the-box support                                     | Direct support                                             |
| REST API management support | Integrated REST API management platform                       | Requires additional coding to support                      |
| Scalability                 | Soft limit of 10,000 RPS                                      | No predetermined scalability limits                        |

**Consistent Hashing**: used in distributed systems to keep the hash table independent of the number of servers available to minimize key relocation when changes of scale occur. Adding/removing servers to handle load are even distributed throughout the ring

## Subnetting

Understanding how to read / break a network down into subnets with ya boy, [Sunny](https://youtu.be/ecCuyq-Wprc).

**Question**:
Network ID: 192.168.4.0/24
Break into 6 subnets

**Solution**:
We will end up with 8 subnets (powers of 2). 2 subnets will not be used. Subnet mask is /27 for all 8 subnets. The number of usable host IDs is 30. First IP is for the network ID and the last IP is reserved for the broadcast ID.

| Subnet | 1     | 2     | 4    | 8    | 16   | 32  | 64  | 128   | 256   |
| ------ | ----- | ----- | ---- | ---- | ---- | --- | --- | ----- | ----- |
| Host   | 256-2 | 128-2 | 64-2 | 32-2 | 16-2 | 8-2 | 4-2 | 2-2=0 | 1-2=? |
| Mask   | /24   | /25   | /26  | /27  | /28  | /29 | /30 | /31   | /32   |

|     | Network ID     | Host ID range                 | Broadcast ID  |
| --- | -------------- | ----------------------------- | ------------- |
| 1   | 192.168.4.000, | 192.168.4.001 - 192.168.4.030 | 192.168.4.031 |
| 2   | 192.168.4.032, | 192.168.4.033 - 192.168.4.062 | 192.168.4.063 |
| 3   | 192.168.4.064, | 192.168.4.065 - 192.168.4.094 | 192.168.4.095 |
| 4   | 192.168.4.096, | 192.168.4.097 - 192.168.4.126 | 192.168.4.127 |
| 5   | 192.168.4.128, | 192.168.4.129 - 192.168.4.158 | 192.168.4.159 |
| 6   | 192.168.4.160  | 192.168.4.161 - 192.168.4.190 | 192.168.4.191 |
| 7   | 192.168.4.192, | 192.168.4.193 - 192.168.4.222 | 192.168.4.223 |
| 8   | 192.168.4.224, | 192.168.4.225 - 192.168.4.254 | 192.168.4.255 |
