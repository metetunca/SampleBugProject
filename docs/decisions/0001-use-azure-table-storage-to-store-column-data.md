# Use Azure Table Storage to store column data

* Status: proposed
* Date: 2023-02-27

## Context and Problem Statement

As an admin user I want to able configure a column in the cost category to Drop Down

## Considered Options

* Azure table storage and Azure blob storage

## Decision Outcome

Chosen option: "Azure table storage", because It supports larger file/json size to save per section. If you want to store flexible datasets like user data for web applications, Microsoft reccommends to use it. 
https://learn.microsoft.com/en-us/azure/storage/common/storage-introduction
